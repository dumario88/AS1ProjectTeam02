namespace AS1ProjectTeam02
{
    partial class RealEstateTransactionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bedrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bathrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.CitySelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedroomsSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BathroomsSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceAreaSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseTypeSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelCountDisplay = new System.Windows.Forms.Label();
            this.labelAveragePriceDisplay = new System.Windows.Forms.Label();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.listBoxBedrooms = new System.Windows.Forms.ListBox();
            this.listBoxBathrooms = new System.Windows.Forms.ListBox();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinSurfaceArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxSurfaceArea = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelAveragePrice = new System.Windows.Forms.Label();
            this.labelSurfaceAreaMin = new System.Windows.Forms.Label();
            this.labelSurfaceAreaMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCities = new System.Windows.Forms.Label();
            this.labelBedrooms = new System.Windows.Forms.Label();
            this.labelBathrooms = new System.Windows.Forms.Label();
            this.labelTypes = new System.Windows.Forms.Label();
            this.labelSurface = new System.Windows.Forms.Label();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxSurfaceArea = new System.Windows.Forms.CheckBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelTransactions = new System.Windows.Forms.Label();
            this.labelSelectedTransactions = new System.Windows.Forms.Label();
            this.labelAveragePrice2 = new System.Windows.Forms.Label();
            this.labelAveragePriceDisplay2 = new System.Windows.Forms.Label();
            this.labelCount2 = new System.Windows.Forms.Label();
            this.labelCountDisplay2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.Address,
            this.Bedrooms,
            this.Bathrooms,
            this.SurfaceArea,
            this.HouseType,
            this.Price});
            this.dataGridViewAll.Location = new System.Drawing.Point(55, 52);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.RowTemplate.Height = 28;
            this.dataGridViewAll.Size = new System.Drawing.Size(977, 339);
            this.dataGridViewAll.TabIndex = 0;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Bedrooms
            // 
            this.Bedrooms.HeaderText = "Bedrooms";
            this.Bedrooms.Name = "Bedrooms";
            // 
            // Bathrooms
            // 
            this.Bathrooms.HeaderText = "Bathrooms";
            this.Bathrooms.Name = "Bathrooms";
            // 
            // SurfaceArea
            // 
            this.SurfaceArea.HeaderText = "SurfaceArea";
            this.SurfaceArea.Name = "SurfaceArea";
            // 
            // HouseType
            // 
            this.HouseType.HeaderText = "HouseType";
            this.HouseType.Name = "HouseType";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CitySelected,
            this.AddressSelected,
            this.BedroomsSelected,
            this.BathroomsSelected,
            this.SurfaceAreaSelected,
            this.HouseTypeSelected,
            this.PriceSelected});
            this.dataGridViewSelected.Location = new System.Drawing.Point(72, 729);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.RowTemplate.Height = 28;
            this.dataGridViewSelected.Size = new System.Drawing.Size(986, 187);
            this.dataGridViewSelected.TabIndex = 1;
            // 
            // CitySelected
            // 
            this.CitySelected.HeaderText = "City";
            this.CitySelected.Name = "CitySelected";
            // 
            // AddressSelected
            // 
            this.AddressSelected.HeaderText = "Address";
            this.AddressSelected.Name = "AddressSelected";
            // 
            // BedroomsSelected
            // 
            this.BedroomsSelected.HeaderText = "Bedrooms";
            this.BedroomsSelected.Name = "BedroomsSelected";
            // 
            // BathroomsSelected
            // 
            this.BathroomsSelected.HeaderText = "Bathrooms";
            this.BathroomsSelected.Name = "BathroomsSelected";
            // 
            // SurfaceAreaSelected
            // 
            this.SurfaceAreaSelected.HeaderText = "SurfaceArea";
            this.SurfaceAreaSelected.Name = "SurfaceAreaSelected";
            // 
            // HouseTypeSelected
            // 
            this.HouseTypeSelected.HeaderText = "HouseType";
            this.HouseTypeSelected.Name = "HouseTypeSelected";
            // 
            // PriceSelected
            // 
            this.PriceSelected.HeaderText = "Price";
            this.PriceSelected.Name = "PriceSelected";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(576, 397);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(122, 40);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset Fields";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelCountDisplay
            // 
            this.labelCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountDisplay.Location = new System.Drawing.Point(225, 409);
            this.labelCountDisplay.Name = "labelCountDisplay";
            this.labelCountDisplay.Size = new System.Drawing.Size(76, 20);
            this.labelCountDisplay.TabIndex = 3;
            // 
            // labelAveragePriceDisplay
            // 
            this.labelAveragePriceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAveragePriceDisplay.Location = new System.Drawing.Point(870, 406);
            this.labelAveragePriceDisplay.Name = "labelAveragePriceDisplay";
            this.labelAveragePriceDisplay.Size = new System.Drawing.Size(126, 30);
            this.labelAveragePriceDisplay.TabIndex = 4;
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.ItemHeight = 20;
            this.listBoxCities.Location = new System.Drawing.Point(181, 462);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.ScrollAlwaysVisible = true;
            this.listBoxCities.Size = new System.Drawing.Size(120, 84);
            this.listBoxCities.TabIndex = 5;
            this.listBoxCities.SelectedIndexChanged += new System.EventHandler(this.listBoxCities_SelectedIndexChanged);
            // 
            // listBoxBedrooms
            // 
            this.listBoxBedrooms.FormattingEnabled = true;
            this.listBoxBedrooms.ItemHeight = 20;
            this.listBoxBedrooms.Location = new System.Drawing.Point(387, 462);
            this.listBoxBedrooms.Name = "listBoxBedrooms";
            this.listBoxBedrooms.Size = new System.Drawing.Size(120, 84);
            this.listBoxBedrooms.TabIndex = 6;
            this.listBoxBedrooms.SelectedIndexChanged += new System.EventHandler(this.listBoxBedrooms_SelectedIndexChanged);
            // 
            // listBoxBathrooms
            // 
            this.listBoxBathrooms.FormattingEnabled = true;
            this.listBoxBathrooms.ItemHeight = 20;
            this.listBoxBathrooms.Location = new System.Drawing.Point(599, 462);
            this.listBoxBathrooms.Name = "listBoxBathrooms";
            this.listBoxBathrooms.Size = new System.Drawing.Size(120, 84);
            this.listBoxBathrooms.TabIndex = 7;
            this.listBoxBathrooms.SelectedIndexChanged += new System.EventHandler(this.listBoxBathrooms_SelectedIndexChanged);
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.ItemHeight = 20;
            this.listBoxTypes.Location = new System.Drawing.Point(810, 462);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(120, 84);
            this.listBoxTypes.TabIndex = 8;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(201, 588);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxMinPrice.TabIndex = 9;
            this.textBoxMinPrice.TextChanged += new System.EventHandler(this.textBoxMinPrice_TextChanged);
            // 
            // textBoxMinSurfaceArea
            // 
            this.textBoxMinSurfaceArea.Location = new System.Drawing.Point(692, 588);
            this.textBoxMinSurfaceArea.Name = "textBoxMinSurfaceArea";
            this.textBoxMinSurfaceArea.Size = new System.Drawing.Size(100, 26);
            this.textBoxMinSurfaceArea.TabIndex = 10;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(201, 633);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxMaxPrice.TabIndex = 11;
            this.textBoxMaxPrice.TextChanged += new System.EventHandler(this.textBoxMaxPrice_TextChanged);
            // 
            // textBoxMaxSurfaceArea
            // 
            this.textBoxMaxSurfaceArea.Location = new System.Drawing.Point(692, 633);
            this.textBoxMaxSurfaceArea.Name = "textBoxMaxSurfaceArea";
            this.textBoxMaxSurfaceArea.Size = new System.Drawing.Size(100, 26);
            this.textBoxMaxSurfaceArea.TabIndex = 12;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(139, 409);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 20);
            this.labelCount.TabIndex = 13;
            this.labelCount.Text = "Count = ";
            // 
            // labelAveragePrice
            // 
            this.labelAveragePrice.AutoSize = true;
            this.labelAveragePrice.Location = new System.Drawing.Point(744, 407);
            this.labelAveragePrice.Name = "labelAveragePrice";
            this.labelAveragePrice.Size = new System.Drawing.Size(120, 20);
            this.labelAveragePrice.TabIndex = 14;
            this.labelAveragePrice.Text = "Average Price =";
            // 
            // labelSurfaceAreaMin
            // 
            this.labelSurfaceAreaMin.AutoSize = true;
            this.labelSurfaceAreaMin.Location = new System.Drawing.Point(613, 593);
            this.labelSurfaceAreaMin.Name = "labelSurfaceAreaMin";
            this.labelSurfaceAreaMin.Size = new System.Drawing.Size(38, 20);
            this.labelSurfaceAreaMin.TabIndex = 15;
            this.labelSurfaceAreaMin.Text = "Min:";
            // 
            // labelSurfaceAreaMax
            // 
            this.labelSurfaceAreaMax.AutoSize = true;
            this.labelSurfaceAreaMax.Location = new System.Drawing.Point(613, 633);
            this.labelSurfaceAreaMax.Name = "labelSurfaceAreaMax";
            this.labelSurfaceAreaMax.Size = new System.Drawing.Size(42, 20);
            this.labelSurfaceAreaMax.TabIndex = 16;
            this.labelSurfaceAreaMax.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Max:";
            // 
            // labelCities
            // 
            this.labelCities.AutoSize = true;
            this.labelCities.Location = new System.Drawing.Point(181, 440);
            this.labelCities.Name = "labelCities";
            this.labelCities.Size = new System.Drawing.Size(48, 20);
            this.labelCities.TabIndex = 19;
            this.labelCities.Text = "Cities";
            // 
            // labelBedrooms
            // 
            this.labelBedrooms.AutoSize = true;
            this.labelBedrooms.Location = new System.Drawing.Point(387, 439);
            this.labelBedrooms.Name = "labelBedrooms";
            this.labelBedrooms.Size = new System.Drawing.Size(82, 20);
            this.labelBedrooms.TabIndex = 20;
            this.labelBedrooms.Text = "Bedrooms";
            // 
            // labelBathrooms
            // 
            this.labelBathrooms.AutoSize = true;
            this.labelBathrooms.Location = new System.Drawing.Point(599, 440);
            this.labelBathrooms.Name = "labelBathrooms";
            this.labelBathrooms.Size = new System.Drawing.Size(87, 20);
            this.labelBathrooms.TabIndex = 21;
            this.labelBathrooms.Text = "Bathrooms";
            // 
            // labelTypes
            // 
            this.labelTypes.AutoSize = true;
            this.labelTypes.Location = new System.Drawing.Point(806, 440);
            this.labelTypes.Name = "labelTypes";
            this.labelTypes.Size = new System.Drawing.Size(102, 20);
            this.labelTypes.TabIndex = 22;
            this.labelTypes.Text = "House Types";
            // 
            // labelSurface
            // 
            this.labelSurface.AutoSize = true;
            this.labelSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSurface.Location = new System.Drawing.Point(489, 550);
            this.labelSurface.Name = "labelSurface";
            this.labelSurface.Size = new System.Drawing.Size(105, 22);
            this.labelSurface.TabIndex = 23;
            this.labelSurface.Text = "Surface Area";
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(181, 665);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(147, 24);
            this.checkBoxPrice.TabIndex = 24;
            this.checkBoxPrice.Text = "Search on Price";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxSurfaceArea
            // 
            this.checkBoxSurfaceArea.AutoSize = true;
            this.checkBoxSurfaceArea.Location = new System.Drawing.Point(652, 665);
            this.checkBoxSurfaceArea.Name = "checkBoxSurfaceArea";
            this.checkBoxSurfaceArea.Size = new System.Drawing.Size(209, 24);
            this.checkBoxSurfaceArea.TabIndex = 25;
            this.checkBoxSurfaceArea.Text = "Search On Surface Area";
            this.checkBoxSurfaceArea.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrice.Location = new System.Drawing.Point(27, 550);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(46, 22);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Price";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.Location = new System.Drawing.Point(12, 405);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(61, 22);
            this.labelFilters.TabIndex = 27;
            this.labelFilters.Text = "Filters";
            // 
            // labelTransactions
            // 
            this.labelTransactions.AutoSize = true;
            this.labelTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransactions.Location = new System.Drawing.Point(12, 9);
            this.labelTransactions.Name = "labelTransactions";
            this.labelTransactions.Size = new System.Drawing.Size(139, 22);
            this.labelTransactions.TabIndex = 28;
            this.labelTransactions.Text = "All Transactions";
            // 
            // labelSelectedTransactions
            // 
            this.labelSelectedTransactions.AutoSize = true;
            this.labelSelectedTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedTransactions.Location = new System.Drawing.Point(27, 704);
            this.labelSelectedTransactions.Name = "labelSelectedTransactions";
            this.labelSelectedTransactions.Size = new System.Drawing.Size(190, 22);
            this.labelSelectedTransactions.TabIndex = 29;
            this.labelSelectedTransactions.Text = "Selected Transactions";
            // 
            // labelAveragePrice2
            // 
            this.labelAveragePrice2.AutoSize = true;
            this.labelAveragePrice2.Location = new System.Drawing.Point(762, 919);
            this.labelAveragePrice2.Name = "labelAveragePrice2";
            this.labelAveragePrice2.Size = new System.Drawing.Size(120, 20);
            this.labelAveragePrice2.TabIndex = 30;
            this.labelAveragePrice2.Text = "Average Price =";
            // 
            // labelAveragePriceDisplay2
            // 
            this.labelAveragePriceDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAveragePriceDisplay2.Location = new System.Drawing.Point(888, 918);
            this.labelAveragePriceDisplay2.Name = "labelAveragePriceDisplay2";
            this.labelAveragePriceDisplay2.Size = new System.Drawing.Size(115, 30);
            this.labelAveragePriceDisplay2.TabIndex = 31;
            // 
            // labelCount2
            // 
            this.labelCount2.AutoSize = true;
            this.labelCount2.Location = new System.Drawing.Point(197, 919);
            this.labelCount2.Name = "labelCount2";
            this.labelCount2.Size = new System.Drawing.Size(69, 20);
            this.labelCount2.TabIndex = 32;
            this.labelCount2.Text = "Count = ";
            // 
            // labelCountDisplay2
            // 
            this.labelCountDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCountDisplay2.Location = new System.Drawing.Point(272, 918);
            this.labelCountDisplay2.Name = "labelCountDisplay2";
            this.labelCountDisplay2.Size = new System.Drawing.Size(76, 20);
            this.labelCountDisplay2.TabIndex = 33;
            // 
            // RealEstateTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 1050);
            this.Controls.Add(this.labelCountDisplay2);
            this.Controls.Add(this.labelCount2);
            this.Controls.Add(this.labelAveragePriceDisplay2);
            this.Controls.Add(this.labelAveragePrice2);
            this.Controls.Add(this.labelSelectedTransactions);
            this.Controls.Add(this.labelTransactions);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.checkBoxSurfaceArea);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.labelSurface);
            this.Controls.Add(this.labelTypes);
            this.Controls.Add(this.labelBathrooms);
            this.Controls.Add(this.labelBedrooms);
            this.Controls.Add(this.labelCities);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSurfaceAreaMax);
            this.Controls.Add(this.labelSurfaceAreaMin);
            this.Controls.Add(this.labelAveragePrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxMaxSurfaceArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinSurfaceArea);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.listBoxTypes);
            this.Controls.Add(this.listBoxBathrooms);
            this.Controls.Add(this.listBoxBedrooms);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.labelAveragePriceDisplay);
            this.Controls.Add(this.labelCountDisplay);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dataGridViewSelected);
            this.Controls.Add(this.dataGridViewAll);
            this.Name = "RealEstateTransactionsForm";
            this.Text = "RealEstateTransactionsForm";
            this.Load += new System.EventHandler(this.RealEstateTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.DataGridView dataGridViewSelected;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelCountDisplay;
        private System.Windows.Forms.Label labelAveragePriceDisplay;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.ListBox listBoxBedrooms;
        private System.Windows.Forms.ListBox listBoxBathrooms;
        private System.Windows.Forms.ListBox listBoxTypes;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMinSurfaceArea;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMaxSurfaceArea;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelAveragePrice;
        private System.Windows.Forms.Label labelSurfaceAreaMin;
        private System.Windows.Forms.Label labelSurfaceAreaMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCities;
        private System.Windows.Forms.Label labelBedrooms;
        private System.Windows.Forms.Label labelBathrooms;
        private System.Windows.Forms.Label labelTypes;
        private System.Windows.Forms.Label labelSurface;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxSurfaceArea;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelTransactions;
        private System.Windows.Forms.Label labelSelectedTransactions;
        private System.Windows.Forms.Label labelAveragePrice2;
        private System.Windows.Forms.Label labelAveragePriceDisplay2;
        private System.Windows.Forms.Label labelCount2;
        private System.Windows.Forms.Label labelCountDisplay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bedrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bathrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitySelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedroomsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn BathroomsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceAreaSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseTypeSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSelected;
    }
}

