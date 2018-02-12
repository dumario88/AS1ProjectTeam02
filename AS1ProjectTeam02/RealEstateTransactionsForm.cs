using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AS1ProjectTeam02
{
    public partial class RealEstateTransactionsForm : Form
    {
        // list that holds all the values that you query
        List<House> transactionsList;
        public RealEstateTransactionsForm()
        {
            InitializeComponent();
            // call method that gets the XML file and stores it in the transactions list
            OpenTheXML();

            InitializeAllOtherFormControls();

            PopulateDataGridAll();



        }

        public void OpenTheXML()
        {
            OpenFileDialog openFileDialogXML = new OpenFileDialog();
            StreamReader inputFile;

            if (openFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                // stores open text in file
                inputFile = File.OpenText(openFileDialogXML.FileName);
            }
            else return; // failure!!

            // Xml serializer
            XmlSerializer listSerializer = new XmlSerializer(typeof(List<House>));
            // reads file into list
            transactionsList = listSerializer.Deserialize(inputFile) as List<House>;
            inputFile.Close();
        }

        public void InitializeAllOtherFormControls()
        {
            listBoxCities.Items.Clear();
            listBoxCities.Width = 100;
            listBoxCities.SelectionMode = SelectionMode.MultiExtended;

            listBoxTypes.Items.Clear();
            listBoxTypes.Width = 100;
            listBoxTypes.SelectionMode = SelectionMode.MultiExtended;

            listBoxBathrooms.Items.Clear();
            listBoxBathrooms.Width = 100;
            listBoxBathrooms.SelectionMode = SelectionMode.MultiExtended;

            listBoxBedrooms.Items.Clear();
            listBoxBedrooms.Width = 100;
            listBoxBedrooms.SelectionMode = SelectionMode.MultiExtended;

            // TASK: create LINQ query or methods/lambdas to generate
            // a unique list of neighborhoods from the rentalHousingList
            // then add this list of neighborhoods to the listbox
            // make sure all neighborhoods are in UPPERCASE in the listbox
            // query for names
            var cities = from home in transactionsList
                        orderby home.City
                        select home.City.ToUpper();



            var bedrooms = from home in transactionsList
                         orderby home.Bedrooms
                         select home.Bedrooms.ToString();

            var bathrooms = from home in transactionsList
                           orderby home.Bathrooms
                           select home.Bathrooms.ToString();

            var types = from type in transactionsList
                        orderby type.HouseType
                        select type.HouseType;

            // adds the names you have searched for and adds them to an array
            listBoxCities.Items.AddRange(cities.Distinct().ToArray());
            listBoxBedrooms.Items.AddRange(bedrooms.Distinct().ToArray());
            listBoxBathrooms.Items.AddRange(bathrooms.Distinct().ToArray());
            listBoxTypes.Items.AddRange(types.Distinct().ToArray());
        }

        public void PopulateDataGridAll()
        {

            var allHomes = from home in transactionsList
                           orderby home.City, home.HouseType, home.Price
                           select home;

            dataGridViewAll.Rows.Clear();

            foreach (House homes in allHomes)
            {
                dataGridViewAll.Rows.Add(homes.City, homes.Address, homes.Bedrooms, homes.Bathrooms, homes.SurfaceArea, homes.HouseType, homes.Price);
            }
            // displays the number of apartments
            labelCountDisplay.Text = allHomes.Count().ToString();
            labelAveragePriceDisplay.Text = allHomes.Average(s => s.Price).ToString("$###,###.##");
            



        }

        public void DisplayRentalHousing()
        {
            // TASK: create a list of chosen neighborhoods from 
            //  listBoxNeighborhoods.SelectedItems (hint, iterate through these)
            //  get the building name from the textbox and convert to UPPERCASE
            //  generate a LINQ query to create a selectedHousing list of RentalHousing
            //     (hint: use a where statement with compound logic
            //     order by neighborhood and building name
            //  display the results of the query in the datagridview control
            //  finally, in the appropriate labels, 
            //     show the number of of apartments (basically, the record count)
            //     and the total number of residences
            List<string> selectedHousingCities = new List<string>();
            List<string> selectedHousingTypes = new List<string>();
            List<string> selectedHousingBathrooms = new List<string>();
            List<string> selectedHousingBedrooms = new List<string>();


            for (int i = 0; i < listBoxCities.SelectedItems.Count; i++)
                selectedHousingCities.Add(listBoxCities.SelectedItems[i].ToString());

            for (int i = 0; i < listBoxTypes.SelectedItems.Count; i++)
                selectedHousingTypes.Add(listBoxTypes.SelectedItems[i].ToString());

            for (int i = 0; i < listBoxBedrooms.SelectedItems.Count; i++)
                selectedHousingBedrooms.Add(listBoxBedrooms.SelectedItems[i].ToString());

            for (int i = 0; i < listBoxBathrooms.SelectedItems.Count; i++)
                selectedHousingBathrooms.Add(listBoxBathrooms.SelectedItems[i].ToString());


            int typedMinPrice = int.Parse(textBoxMinPrice.Text);
            int typedMaxPrice = int.Parse(textBoxMaxPrice.Text);
            //&& home.BuildingName.Contains(typedBuildingName)
            // query that uses the listbox selector to gatekeep which houses are displayed
            var selectedHomes = from home in transactionsList
                                join buildingCites in selectedHousingCities on home.City equals buildingCites
                                join buildingTypes in selectedHousingTypes on home.HouseType equals buildingTypes
                                join buildingBathrooms in selectedHousingBathrooms on home.Bathrooms.ToString() equals buildingBathrooms.ToString()
                                join buildingBedrooms in selectedHousingBedrooms on home.Bedrooms.ToString() equals buildingBedrooms.ToString()
                                where (listBoxCities.SelectedItems.Count > 0) && (home.Price >= typedMinPrice) && (home.Price <= typedMaxPrice)
                                orderby home.City, home.HouseType, home.Price
                                select home;

            dataGridViewSelected.Rows.Clear();

            foreach (House homes in selectedHomes)
            {
                dataGridViewSelected.Rows.Add(homes.City, homes.Address, homes.Bedrooms, homes.Bathrooms, homes.SurfaceArea, homes.HouseType, homes.Price);
            }
            // displays the number of apartments
            labelCountDisplay2.Text = selectedHomes.Count().ToString();
            if(selectedHomes.Count() != 0)
            {
                labelAveragePriceDisplay2.Text = selectedHomes.Average(s => s.Price).ToString("$###,###.##");
            }
            else
            {
                labelAveragePriceDisplay2.Text = "$0.00";
            }
            


        }

        private void RealEstateTransactionsForm_Load(object sender, EventArgs e)
        {

        }
        private void listBoxBedrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRentalHousing();
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRentalHousing();
        }

        private void listBoxBathrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRentalHousing();
        }

        private void listBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRentalHousing();
        }

        private void textBoxMinPrice_TextChanged(object sender, EventArgs e)
        {
            DisplayRentalHousing();
        }

        private void textBoxMaxPrice_TextChanged(object sender, EventArgs e)
        {
            DisplayRentalHousing();
        }
    }
    // Class that helps initialize the list object
    [Serializable]
    public class House
    {
        // each one of these represents the different elements that the XML file contains
        public string Address { get; set; }
        public string City { get; set; }
        public string HouseType { get; set; }
        public int SurfaceArea { get; set; }
        public int Price { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        // override string file
        public override string ToString()
        {
            return $"{Address},{City},{HouseType},{SurfaceArea},{Price},{Bedrooms},{Bathrooms}";
        }
    }

}
