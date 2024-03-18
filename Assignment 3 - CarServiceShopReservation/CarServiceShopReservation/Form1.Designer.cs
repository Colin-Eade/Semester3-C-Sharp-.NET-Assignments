namespace CarServiceShopReservation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            customerInfoLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneLabel = new Label();
            carInfoLabel = new Label();
            makeLabel = new Label();
            modelLabel = new Label();
            yearLabel = new Label();
            colourLabel = new Label();
            servicesLabel = new Label();
            costLabel = new Label();
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            phoneInput = new TextBox();
            makeCombo = new ComboBox();
            yearCombo = new ComboBox();
            colourInput = new TextBox();
            engineOilChangeCheck = new CheckBox();
            transmissionOilChangeCheck = new CheckBox();
            airFilterChangeCheck = new CheckBox();
            costOutput = new TextBox();
            addButton = new Button();
            newButton = new Button();
            updateButton = new Button();
            removeButton = new Button();
            removeAllButton = new Button();
            exitButton = new Button();
            carServiceSummaryList = new ListView();
            serviceNumberHeader = new ColumnHeader();
            firstNameHeader = new ColumnHeader();
            lastNameHeader = new ColumnHeader();
            phoneHeader = new ColumnHeader();
            makeHeader = new ColumnHeader();
            modelHeader = new ColumnHeader();
            yearHeader = new ColumnHeader();
            colourHeader = new ColumnHeader();
            engineOilHeader = new ColumnHeader();
            transmissionOilHeader = new ColumnHeader();
            airFilterHeader = new ColumnHeader();
            costHeader = new ColumnHeader();
            carSeviceSummaryLabel = new Label();
            toolTips = new ToolTip(components);
            modelInput = new TextBox();
            SuspendLayout();
            // 
            // customerInfoLabel
            // 
            customerInfoLabel.AutoSize = true;
            customerInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customerInfoLabel.Location = new Point(10, 10);
            customerInfoLabel.Margin = new Padding(5);
            customerInfoLabel.Name = "customerInfoLabel";
            customerInfoLabel.Size = new Size(131, 15);
            customerInfoLabel.TabIndex = 0;
            customerInfoLabel.Text = "Customer Information";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(10, 35);
            firstNameLabel.Margin = new Padding(5);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(65, 15);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(10, 60);
            lastNameLabel.Margin = new Padding(5);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(64, 15);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(10, 85);
            phoneLabel.Margin = new Padding(5);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(44, 15);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // carInfoLabel
            // 
            carInfoLabel.AutoSize = true;
            carInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carInfoLabel.Location = new Point(10, 125);
            carInfoLabel.Margin = new Padding(5, 20, 5, 5);
            carInfoLabel.Name = "carInfoLabel";
            carInfoLabel.Size = new Size(95, 15);
            carInfoLabel.TabIndex = 7;
            carInfoLabel.Text = "Car Information";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(10, 150);
            makeLabel.Margin = new Padding(5);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(39, 15);
            makeLabel.TabIndex = 8;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(10, 175);
            modelLabel.Margin = new Padding(5);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(44, 15);
            modelLabel.TabIndex = 10;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(10, 200);
            yearLabel.Margin = new Padding(5);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 12;
            yearLabel.Text = "Year:";
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new Point(10, 225);
            colourLabel.Margin = new Padding(5);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new Size(46, 15);
            colourLabel.TabIndex = 14;
            colourLabel.Text = "Colour:";
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.Location = new Point(10, 250);
            servicesLabel.Margin = new Padding(5);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(52, 15);
            servicesLabel.TabIndex = 16;
            servicesLabel.Text = "Services:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(10, 311);
            costLabel.Margin = new Padding(5);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(34, 15);
            costLabel.TabIndex = 20;
            costLabel.Text = "Cost:";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(83, 32);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(150, 23);
            firstNameInput.TabIndex = 2;
            toolTips.SetToolTip(firstNameInput, "Enter the customor's first name");
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(83, 57);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(150, 23);
            lastNameInput.TabIndex = 4;
            toolTips.SetToolTip(lastNameInput, "Enter the customer's last name");
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(83, 82);
            phoneInput.MaxLength = 10;
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(150, 23);
            phoneInput.TabIndex = 6;
            toolTips.SetToolTip(phoneInput, "Enter the customer's phone number");
            // 
            // makeCombo
            // 
            makeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            makeCombo.FormattingEnabled = true;
            makeCombo.Location = new Point(83, 147);
            makeCombo.Name = "makeCombo";
            makeCombo.Size = new Size(150, 23);
            makeCombo.TabIndex = 9;
            toolTips.SetToolTip(makeCombo, "Select the make of the customer's car");
            // 
            // yearCombo
            // 
            yearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            yearCombo.FormattingEnabled = true;
            yearCombo.Location = new Point(83, 197);
            yearCombo.Name = "yearCombo";
            yearCombo.Size = new Size(150, 23);
            yearCombo.TabIndex = 13;
            toolTips.SetToolTip(yearCombo, "Select the year your customer's car was made");
            // 
            // colourInput
            // 
            colourInput.Location = new Point(83, 222);
            colourInput.Name = "colourInput";
            colourInput.Size = new Size(150, 23);
            colourInput.TabIndex = 15;
            toolTips.SetToolTip(colourInput, "Enter the colour of the customer's car");
            // 
            // engineOilChangeCheck
            // 
            engineOilChangeCheck.AutoSize = true;
            engineOilChangeCheck.Location = new Point(83, 249);
            engineOilChangeCheck.Margin = new Padding(0);
            engineOilChangeCheck.Name = "engineOilChangeCheck";
            engineOilChangeCheck.Size = new Size(120, 19);
            engineOilChangeCheck.TabIndex = 17;
            engineOilChangeCheck.Text = "Engine oil change";
            toolTips.SetToolTip(engineOilChangeCheck, "Select if the custmor is getting an engine oil change");
            engineOilChangeCheck.UseVisualStyleBackColor = true;
            engineOilChangeCheck.CheckedChanged += engineOilChangeCheck_CheckedChanged;
            // 
            // transmissionOilChangeCheck
            // 
            transmissionOilChangeCheck.AutoSize = true;
            transmissionOilChangeCheck.Location = new Point(83, 268);
            transmissionOilChangeCheck.Margin = new Padding(0);
            transmissionOilChangeCheck.Name = "transmissionOilChangeCheck";
            transmissionOilChangeCheck.Size = new Size(152, 19);
            transmissionOilChangeCheck.TabIndex = 18;
            transmissionOilChangeCheck.Text = "Transmission oil change";
            toolTips.SetToolTip(transmissionOilChangeCheck, "Select if the custmor is getting an transmission oil change");
            transmissionOilChangeCheck.UseVisualStyleBackColor = true;
            transmissionOilChangeCheck.CheckedChanged += transmissionOilChangeCheck_CheckedChanged;
            // 
            // airFilterChangeCheck
            // 
            airFilterChangeCheck.AutoSize = true;
            airFilterChangeCheck.Location = new Point(83, 287);
            airFilterChangeCheck.Margin = new Padding(0);
            airFilterChangeCheck.Name = "airFilterChangeCheck";
            airFilterChangeCheck.Size = new Size(106, 19);
            airFilterChangeCheck.TabIndex = 19;
            airFilterChangeCheck.Text = "Air filer change";
            toolTips.SetToolTip(airFilterChangeCheck, "Select if the custmor is getting an air filter change");
            airFilterChangeCheck.UseVisualStyleBackColor = true;
            airFilterChangeCheck.CheckedChanged += airFilterChangeCheck_CheckedChanged;
            // 
            // costOutput
            // 
            costOutput.Location = new Point(83, 308);
            costOutput.Name = "costOutput";
            costOutput.ReadOnly = true;
            costOutput.Size = new Size(150, 23);
            costOutput.TabIndex = 21;
            costOutput.Text = "$0.00";
            toolTips.SetToolTip(costOutput, "Service cost output");
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(10, 351);
            addButton.Margin = new Padding(5, 20, 5, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 22;
            addButton.Text = "&Add";
            toolTips.SetToolTip(addButton, "Click to add a new service entry to the car service summary");
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newButton.Location = new Point(95, 351);
            newButton.Margin = new Padding(5, 20, 5, 5);
            newButton.Name = "newButton";
            newButton.Size = new Size(75, 23);
            newButton.TabIndex = 23;
            newButton.Text = "&New";
            toolTips.SetToolTip(newButton, "Click to clear the input fields on the form");
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            updateButton.Location = new Point(180, 351);
            updateButton.Margin = new Padding(5, 20, 5, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 24;
            updateButton.Text = "&Update";
            toolTips.SetToolTip(updateButton, "Click to update a service entry in the car service summary");
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(265, 351);
            removeButton.Margin = new Padding(5, 20, 5, 5);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 25;
            removeButton.Text = "&Remove";
            toolTips.SetToolTip(removeButton, "Click to remove a service entry in the car service summary");
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // removeAllButton
            // 
            removeAllButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeAllButton.Location = new Point(350, 351);
            removeAllButton.Margin = new Padding(5, 20, 5, 5);
            removeAllButton.Name = "removeAllButton";
            removeAllButton.Size = new Size(89, 23);
            removeAllButton.TabIndex = 26;
            removeAllButton.Text = "R&emove All";
            toolTips.SetToolTip(removeAllButton, "Click to remove all entries in the car service summary");
            removeAllButton.UseVisualStyleBackColor = true;
            removeAllButton.Click += removeAllButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1025, 351);
            exitButton.Margin = new Padding(5, 20, 5, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 29;
            exitButton.Text = "E&xit";
            toolTips.SetToolTip(exitButton, "Click to exit the application");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // carServiceSummaryList
            // 
            carServiceSummaryList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServiceSummaryList.Columns.AddRange(new ColumnHeader[] { serviceNumberHeader, firstNameHeader, lastNameHeader, phoneHeader, makeHeader, modelHeader, yearHeader, colourHeader, engineOilHeader, transmissionOilHeader, airFilterHeader, costHeader });
            carServiceSummaryList.FullRowSelect = true;
            carServiceSummaryList.GridLines = true;
            carServiceSummaryList.Location = new Point(256, 32);
            carServiceSummaryList.Margin = new Padding(20, 5, 5, 20);
            carServiceSummaryList.Name = "carServiceSummaryList";
            carServiceSummaryList.Size = new Size(844, 299);
            carServiceSummaryList.TabIndex = 28;
            toolTips.SetToolTip(carServiceSummaryList, "Car service summary table\r\n\r\nSelect a row to edit or remove");
            carServiceSummaryList.UseCompatibleStateImageBehavior = false;
            carServiceSummaryList.View = View.Details;
            carServiceSummaryList.ItemActivate += carServiceSummaryList_ItemActivate;
            // 
            // serviceNumberHeader
            // 
            serviceNumberHeader.Text = "NO";
            serviceNumberHeader.Width = 40;
            // 
            // firstNameHeader
            // 
            firstNameHeader.Text = "First Name";
            firstNameHeader.Width = 80;
            // 
            // lastNameHeader
            // 
            lastNameHeader.Text = "Last Name";
            lastNameHeader.Width = 80;
            // 
            // phoneHeader
            // 
            phoneHeader.Text = "Phone";
            phoneHeader.Width = 100;
            // 
            // makeHeader
            // 
            makeHeader.Text = "Make";
            makeHeader.Width = 80;
            // 
            // modelHeader
            // 
            modelHeader.Text = "Model";
            modelHeader.Width = 80;
            // 
            // yearHeader
            // 
            yearHeader.Text = "Year";
            // 
            // colourHeader
            // 
            colourHeader.Text = "Colour";
            colourHeader.Width = 80;
            // 
            // engineOilHeader
            // 
            engineOilHeader.Text = "Eng Oil Chg";
            // 
            // transmissionOilHeader
            // 
            transmissionOilHeader.Text = "Trans Oil Chg";
            // 
            // airFilterHeader
            // 
            airFilterHeader.Text = "Air Fil Chg";
            // 
            // costHeader
            // 
            costHeader.Text = "Cost ($)";
            // 
            // carSeviceSummaryLabel
            // 
            carSeviceSummaryLabel.AutoSize = true;
            carSeviceSummaryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carSeviceSummaryLabel.Location = new Point(256, 10);
            carSeviceSummaryLabel.Margin = new Padding(5);
            carSeviceSummaryLabel.Name = "carSeviceSummaryLabel";
            carSeviceSummaryLabel.Size = new Size(126, 15);
            carSeviceSummaryLabel.TabIndex = 27;
            carSeviceSummaryLabel.Text = "Car Service Summary";
            // 
            // modelInput
            // 
            modelInput.Location = new Point(83, 172);
            modelInput.Name = "modelInput";
            modelInput.Size = new Size(150, 23);
            modelInput.TabIndex = 11;
            toolTips.SetToolTip(modelInput, "Enter the customer's phone number");
            // 
            // Form1
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = newButton;
            ClientSize = new Size(1110, 384);
            Controls.Add(modelInput);
            Controls.Add(carSeviceSummaryLabel);
            Controls.Add(carServiceSummaryList);
            Controls.Add(exitButton);
            Controls.Add(removeAllButton);
            Controls.Add(removeButton);
            Controls.Add(updateButton);
            Controls.Add(newButton);
            Controls.Add(addButton);
            Controls.Add(costOutput);
            Controls.Add(airFilterChangeCheck);
            Controls.Add(transmissionOilChangeCheck);
            Controls.Add(engineOilChangeCheck);
            Controls.Add(colourInput);
            Controls.Add(yearCombo);
            Controls.Add(makeCombo);
            Controls.Add(phoneInput);
            Controls.Add(lastNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(costLabel);
            Controls.Add(servicesLabel);
            Controls.Add(colourLabel);
            Controls.Add(yearLabel);
            Controls.Add(modelLabel);
            Controls.Add(makeLabel);
            Controls.Add(carInfoLabel);
            Controls.Add(phoneLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(customerInfoLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(535, 419);
            Name = "Form1";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Service Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerInfoLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneLabel;
        private Label carInfoLabel;
        private Label makeLabel;
        private Label modelLabel;
        private Label yearLabel;
        private Label colourLabel;
        private Label servicesLabel;
        private Label costLabel;
        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private TextBox phoneInput;
        private ComboBox makeCombo;
        private ComboBox yearCombo;
        private TextBox colourInput;
        private CheckBox engineOilChangeCheck;
        private CheckBox transmissionOilChangeCheck;
        private CheckBox airFilterChangeCheck;
        private TextBox costOutput;
        private Button addButton;
        private Button newButton;
        private Button updateButton;
        private Button removeButton;
        private Button removeAllButton;
        private Button exitButton;
        private ListView carServiceSummaryList;
        private Label carSeviceSummaryLabel;
        private ColumnHeader serviceNumberHeader;
        private ColumnHeader firstNameHeader;
        private ColumnHeader lastNameHeader;
        private ColumnHeader phoneHeader;
        private ColumnHeader makeHeader;
        private ColumnHeader modelHeader;
        private ColumnHeader yearHeader;
        private ColumnHeader colourHeader;
        private ColumnHeader engineOilHeader;
        private ColumnHeader transmissionOilHeader;
        private ColumnHeader airFilterHeader;
        private ColumnHeader costHeader;
        private ToolTip toolTips;
        private TextBox modelInput;
    }
}