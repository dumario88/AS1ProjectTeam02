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
        List<House> transactionsList;
        public RealEstateTransactionsForm()
        {
            InitializeComponent();

            OpenTheXML();
        }

        public void OpenTheXML()
        {
            OpenFileDialog openFileDialogXML = new OpenFileDialog();
            StreamReader inputFile;

            if (openFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialogXML.FileName);
            }
            else return; // failure!!

            // Xml serializer
            XmlSerializer listSerializer = new XmlSerializer(typeof(List<House>));
            // reads file into list
            transactionsList = listSerializer.Deserialize(inputFile) as List<House>;
            inputFile.Close();
            Console.WriteLine(transactionsList);

        }
    }
    [Serializable]
    public class House
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string HouseType { get; set; }
        public int SurfaceArea { get; set; }
        public int Price { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }

        public override string ToString()
        {
            return $"{Address},{City},{HouseType},{SurfaceArea},{Price},{Bedrooms},{Bathrooms}";
        }
    }

}
