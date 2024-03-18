namespace RegistrationApp
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
            studentInfoGroup = new GroupBox();
            gradeCombo = new ComboBox();
            admissionTestCombo = new ComboBox();
            sinInput = new TextBox();
            emailInput = new TextBox();
            lastNameInput = new TextBox();
            firstNameInput = new TextBox();
            gradeLabel = new Label();
            admissionTestLabel = new Label();
            emailLabel = new Label();
            sinLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            checkButton = new Button();
            availableProgramsGroup = new GroupBox();
            totalCostOutput = new Label();
            studyPeriodOutput = new Label();
            programsCombo = new ComboBox();
            campusLocationCombo = new ComboBox();
            totalCostLabel = new Label();
            studyPeriodLabel = new Label();
            programsLabel = new Label();
            campusLocationLabel = new Label();
            registerButton = new Button();
            studentDataGrid = new DataGridView();
            firstNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn = new DataGridViewTextBoxColumn();
            sinColumn = new DataGridViewTextBoxColumn();
            emailColumn = new DataGridViewTextBoxColumn();
            gradeColumn = new DataGridViewTextBoxColumn();
            admissionTestColumn = new DataGridViewTextBoxColumn();
            campusLocationColumn = new DataGridViewTextBoxColumn();
            programColumn = new DataGridViewTextBoxColumn();
            deleteRecordButton = new Button();
            updateRecordButton = new Button();
            sinLabel2 = new Label();
            sinCombo = new ComboBox();
            removeAllRecordsButton = new Button();
            loadToServerButton = new Button();
            exitButton = new Button();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            recordToolStripMenuItem = new ToolStripMenuItem();
            updateRecordToolStripMenuItem = new ToolStripMenuItem();
            deleteRecordToolStripMenuItem = new ToolStripMenuItem();
            deleteAllRecordsToolStripMenuItem = new ToolStripMenuItem();
            loadRecordsToServerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            readHelpToolStripMenuItem = new ToolStripMenuItem();
            technicalSupportToolStripMenuItem = new ToolStripMenuItem();
            aboutRegistrationAppToolStripMenuItem = new ToolStripMenuItem();
            toolTips = new ToolTip(components);
            studentInfoGroup.SuspendLayout();
            availableProgramsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGrid).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // studentInfoGroup
            // 
            studentInfoGroup.Controls.Add(gradeCombo);
            studentInfoGroup.Controls.Add(admissionTestCombo);
            studentInfoGroup.Controls.Add(sinInput);
            studentInfoGroup.Controls.Add(emailInput);
            studentInfoGroup.Controls.Add(lastNameInput);
            studentInfoGroup.Controls.Add(firstNameInput);
            studentInfoGroup.Controls.Add(gradeLabel);
            studentInfoGroup.Controls.Add(admissionTestLabel);
            studentInfoGroup.Controls.Add(emailLabel);
            studentInfoGroup.Controls.Add(sinLabel);
            studentInfoGroup.Controls.Add(lastNameLabel);
            studentInfoGroup.Controls.Add(firstNameLabel);
            studentInfoGroup.Location = new Point(17, 26);
            studentInfoGroup.Margin = new Padding(9, 8, 9, 8);
            studentInfoGroup.Name = "studentInfoGroup";
            studentInfoGroup.Padding = new Padding(9, 8, 9, 8);
            studentInfoGroup.Size = new Size(1001, 98);
            studentInfoGroup.TabIndex = 0;
            studentInfoGroup.TabStop = false;
            studentInfoGroup.Text = "Student Information";
            // 
            // gradeCombo
            // 
            gradeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gradeCombo.FormattingEnabled = true;
            gradeCombo.Items.AddRange(new object[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            gradeCombo.Location = new Point(783, 58);
            gradeCombo.Margin = new Padding(9, 8, 9, 8);
            gradeCombo.Name = "gradeCombo";
            gradeCombo.Size = new Size(199, 23);
            gradeCombo.TabIndex = 11;
            toolTips.SetToolTip(gradeCombo, "Select the student high school grade.");
            gradeCombo.SelectedIndexChanged += ResetControlBackColor;
            // 
            // admissionTestCombo
            // 
            admissionTestCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            admissionTestCombo.FormattingEnabled = true;
            admissionTestCombo.Items.AddRange(new object[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            admissionTestCombo.Location = new Point(783, 28);
            admissionTestCombo.Margin = new Padding(9, 8, 9, 8);
            admissionTestCombo.Name = "admissionTestCombo";
            admissionTestCombo.Size = new Size(199, 23);
            admissionTestCombo.TabIndex = 9;
            toolTips.SetToolTip(admissionTestCombo, "Select the student admission test score.");
            admissionTestCombo.SelectedIndexChanged += ResetControlBackColor;
            // 
            // sinInput
            // 
            sinInput.Location = new Point(399, 28);
            sinInput.Margin = new Padding(9, 8, 9, 8);
            sinInput.MaxLength = 9;
            sinInput.Name = "sinInput";
            sinInput.Size = new Size(219, 23);
            sinInput.TabIndex = 5;
            toolTips.SetToolTip(sinInput, "Enter the student SIN.");
            sinInput.Click += ResetControlBackColor;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(399, 58);
            emailInput.Margin = new Padding(9, 8, 9, 8);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(219, 23);
            emailInput.TabIndex = 7;
            toolTips.SetToolTip(emailInput, "Enter the student email address.");
            emailInput.Click += ResetControlBackColor;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(105, 58);
            lastNameInput.Margin = new Padding(9, 8, 9, 8);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(219, 23);
            lastNameInput.TabIndex = 3;
            toolTips.SetToolTip(lastNameInput, "Enter the student last name.");
            lastNameInput.Click += ResetControlBackColor;
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(105, 28);
            firstNameInput.Margin = new Padding(9, 8, 9, 8);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(219, 23);
            firstNameInput.TabIndex = 1;
            toolTips.SetToolTip(firstNameInput, "Enter the student first name.");
            firstNameInput.Click += ResetControlBackColor;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new Point(635, 60);
            gradeLabel.Margin = new Padding(9, 8, 9, 8);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(106, 15);
            gradeLabel.TabIndex = 10;
            gradeLabel.Text = "High School Grade";
            // 
            // admissionTestLabel
            // 
            admissionTestLabel.AutoSize = true;
            admissionTestLabel.Location = new Point(635, 30);
            admissionTestLabel.Margin = new Padding(9, 8, 9, 8);
            admissionTestLabel.Name = "admissionTestLabel";
            admissionTestLabel.Size = new Size(118, 15);
            admissionTestLabel.TabIndex = 8;
            admissionTestLabel.Text = "Admission Test Score";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(341, 60);
            emailLabel.Margin = new Padding(9, 8, 9, 8);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // sinLabel
            // 
            sinLabel.AutoSize = true;
            sinLabel.Location = new Point(341, 30);
            sinLabel.Margin = new Padding(9, 8, 9, 8);
            sinLabel.Name = "sinLabel";
            sinLabel.Size = new Size(25, 15);
            sinLabel.TabIndex = 4;
            sinLabel.Text = "SIN";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(18, 60);
            lastNameLabel.Margin = new Padding(9, 8, 9, 8);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(18, 30);
            firstNameLabel.Margin = new Padding(9, 8, 9, 8);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(17, 138);
            checkButton.Margin = new Padding(9, 8, 9, 8);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(131, 22);
            checkButton.TabIndex = 1;
            checkButton.Text = "&Check";
            toolTips.SetToolTip(checkButton, "Click to check if a student is eligible for any campuses.");
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += CheckEligibility;
            // 
            // availableProgramsGroup
            // 
            availableProgramsGroup.Controls.Add(totalCostOutput);
            availableProgramsGroup.Controls.Add(studyPeriodOutput);
            availableProgramsGroup.Controls.Add(programsCombo);
            availableProgramsGroup.Controls.Add(campusLocationCombo);
            availableProgramsGroup.Controls.Add(totalCostLabel);
            availableProgramsGroup.Controls.Add(studyPeriodLabel);
            availableProgramsGroup.Controls.Add(programsLabel);
            availableProgramsGroup.Controls.Add(campusLocationLabel);
            availableProgramsGroup.Enabled = false;
            availableProgramsGroup.Location = new Point(17, 175);
            availableProgramsGroup.Margin = new Padding(9, 8, 9, 8);
            availableProgramsGroup.Name = "availableProgramsGroup";
            availableProgramsGroup.Padding = new Padding(9, 8, 9, 8);
            availableProgramsGroup.Size = new Size(1001, 90);
            availableProgramsGroup.TabIndex = 2;
            availableProgramsGroup.TabStop = false;
            availableProgramsGroup.Text = "Available Programs";
            // 
            // totalCostOutput
            // 
            totalCostOutput.AutoSize = true;
            totalCostOutput.Location = new Point(910, 57);
            totalCostOutput.Margin = new Padding(9, 8, 9, 8);
            totalCostOutput.Name = "totalCostOutput";
            totalCostOutput.Size = new Size(34, 15);
            totalCostOutput.TabIndex = 7;
            totalCostOutput.Text = "$0.00";
            // 
            // studyPeriodOutput
            // 
            studyPeriodOutput.AutoSize = true;
            studyPeriodOutput.Location = new Point(910, 26);
            studyPeriodOutput.Margin = new Padding(9, 8, 9, 8);
            studyPeriodOutput.Name = "studyPeriodOutput";
            studyPeriodOutput.Size = new Size(28, 15);
            studyPeriodOutput.TabIndex = 5;
            studyPeriodOutput.Text = "0.00";
            // 
            // programsCombo
            // 
            programsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            programsCombo.FormattingEnabled = true;
            programsCombo.Location = new Point(459, 38);
            programsCombo.Margin = new Padding(9, 8, 9, 8);
            programsCombo.Name = "programsCombo";
            programsCombo.Size = new Size(307, 23);
            programsCombo.TabIndex = 3;
            toolTips.SetToolTip(programsCombo, "Select a program. ");
            programsCombo.SelectedIndexChanged += programsCombo_SelectedIndexChanged;
            // 
            // campusLocationCombo
            // 
            campusLocationCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            campusLocationCombo.FormattingEnabled = true;
            campusLocationCombo.Location = new Point(143, 38);
            campusLocationCombo.Margin = new Padding(9, 8, 9, 8);
            campusLocationCombo.Name = "campusLocationCombo";
            campusLocationCombo.Size = new Size(219, 23);
            campusLocationCombo.TabIndex = 1;
            toolTips.SetToolTip(campusLocationCombo, "Select a campus location.");
            campusLocationCombo.SelectedIndexChanged += campusLocationCombo_SelectedIndexChanged;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(818, 57);
            totalCostLabel.Margin = new Padding(9, 8, 9, 8);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(59, 15);
            totalCostLabel.TabIndex = 6;
            totalCostLabel.Text = "Total Cost";
            // 
            // studyPeriodLabel
            // 
            studyPeriodLabel.AutoSize = true;
            studyPeriodLabel.Location = new Point(818, 26);
            studyPeriodLabel.Margin = new Padding(9, 8, 9, 8);
            studyPeriodLabel.Name = "studyPeriodLabel";
            studyPeriodLabel.Size = new Size(74, 15);
            studyPeriodLabel.TabIndex = 4;
            studyPeriodLabel.Text = "Study Period";
            // 
            // programsLabel
            // 
            programsLabel.AutoSize = true;
            programsLabel.Location = new Point(379, 40);
            programsLabel.Margin = new Padding(9, 8, 9, 8);
            programsLabel.Name = "programsLabel";
            programsLabel.Size = new Size(58, 15);
            programsLabel.TabIndex = 2;
            programsLabel.Text = "Programs";
            // 
            // campusLocationLabel
            // 
            campusLocationLabel.AutoSize = true;
            campusLocationLabel.Location = new Point(18, 40);
            campusLocationLabel.Margin = new Padding(9, 8, 9, 8);
            campusLocationLabel.Name = "campusLocationLabel";
            campusLocationLabel.Size = new Size(100, 15);
            campusLocationLabel.TabIndex = 0;
            campusLocationLabel.Text = "Campus Location";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(17, 280);
            registerButton.Margin = new Padding(9, 8, 9, 8);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(131, 22);
            registerButton.TabIndex = 3;
            registerButton.Text = "&Register Student";
            toolTips.SetToolTip(registerButton, "Click to register a student for a campus and program. Registering a student will populate the table below.");
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += RegisterStudent;
            // 
            // studentDataGrid
            // 
            studentDataGrid.AllowUserToAddRows = false;
            studentDataGrid.AllowUserToDeleteRows = false;
            studentDataGrid.AllowUserToResizeRows = false;
            studentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGrid.Columns.AddRange(new DataGridViewColumn[] { firstNameColumn, lastNameColumn, sinColumn, emailColumn, gradeColumn, admissionTestColumn, campusLocationColumn, programColumn });
            studentDataGrid.Location = new Point(15, 316);
            studentDataGrid.Margin = new Padding(9, 8, 9, 8);
            studentDataGrid.Name = "studentDataGrid";
            studentDataGrid.ReadOnly = true;
            studentDataGrid.RowHeadersVisible = false;
            studentDataGrid.RowHeadersWidth = 51;
            studentDataGrid.RowTemplate.Height = 29;
            studentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentDataGrid.Size = new Size(1003, 166);
            studentDataGrid.TabIndex = 4;
            toolTips.SetToolTip(studentDataGrid, "Table displays all registered students.");
            studentDataGrid.SelectionChanged += studentDataGrid_SelectionChanged;
            // 
            // firstNameColumn
            // 
            firstNameColumn.HeaderText = "First Name";
            firstNameColumn.MinimumWidth = 6;
            firstNameColumn.Name = "firstNameColumn";
            firstNameColumn.ReadOnly = true;
            firstNameColumn.Width = 125;
            // 
            // lastNameColumn
            // 
            lastNameColumn.HeaderText = "Last Name";
            lastNameColumn.MinimumWidth = 6;
            lastNameColumn.Name = "lastNameColumn";
            lastNameColumn.ReadOnly = true;
            lastNameColumn.Width = 125;
            // 
            // sinColumn
            // 
            sinColumn.HeaderText = "SIN";
            sinColumn.MinimumWidth = 6;
            sinColumn.Name = "sinColumn";
            sinColumn.ReadOnly = true;
            sinColumn.Width = 125;
            // 
            // emailColumn
            // 
            emailColumn.HeaderText = "Email";
            emailColumn.MinimumWidth = 6;
            emailColumn.Name = "emailColumn";
            emailColumn.ReadOnly = true;
            emailColumn.Width = 125;
            // 
            // gradeColumn
            // 
            gradeColumn.HeaderText = "High School Grade";
            gradeColumn.MinimumWidth = 6;
            gradeColumn.Name = "gradeColumn";
            gradeColumn.ReadOnly = true;
            gradeColumn.Width = 125;
            // 
            // admissionTestColumn
            // 
            admissionTestColumn.HeaderText = "Admssion Test Score";
            admissionTestColumn.MinimumWidth = 6;
            admissionTestColumn.Name = "admissionTestColumn";
            admissionTestColumn.ReadOnly = true;
            admissionTestColumn.Width = 125;
            // 
            // campusLocationColumn
            // 
            campusLocationColumn.HeaderText = "Campus Location";
            campusLocationColumn.MinimumWidth = 6;
            campusLocationColumn.Name = "campusLocationColumn";
            campusLocationColumn.ReadOnly = true;
            campusLocationColumn.Width = 125;
            // 
            // programColumn
            // 
            programColumn.HeaderText = "Program";
            programColumn.MinimumWidth = 6;
            programColumn.Name = "programColumn";
            programColumn.ReadOnly = true;
            programColumn.Width = 125;
            // 
            // deleteRecordButton
            // 
            deleteRecordButton.Location = new Point(17, 499);
            deleteRecordButton.Margin = new Padding(9, 8, 9, 8);
            deleteRecordButton.Name = "deleteRecordButton";
            deleteRecordButton.Size = new Size(131, 22);
            deleteRecordButton.TabIndex = 5;
            deleteRecordButton.Text = "&Delete Record";
            toolTips.SetToolTip(deleteRecordButton, "Click to delete a selected student record.");
            deleteRecordButton.UseVisualStyleBackColor = true;
            deleteRecordButton.Click += DeleteRecord;
            // 
            // updateRecordButton
            // 
            updateRecordButton.Location = new Point(165, 499);
            updateRecordButton.Margin = new Padding(9, 8, 9, 8);
            updateRecordButton.Name = "updateRecordButton";
            updateRecordButton.Size = new Size(131, 22);
            updateRecordButton.TabIndex = 6;
            updateRecordButton.Text = "&Update Record";
            toolTips.SetToolTip(updateRecordButton, "Click to update a selected student record with inputs from the \"Student Information\" section.");
            updateRecordButton.UseVisualStyleBackColor = true;
            updateRecordButton.Click += UpdateRecord;
            // 
            // sinLabel2
            // 
            sinLabel2.AutoSize = true;
            sinLabel2.Location = new Point(17, 536);
            sinLabel2.Margin = new Padding(9, 8, 9, 8);
            sinLabel2.Name = "sinLabel2";
            sinLabel2.Size = new Size(25, 15);
            sinLabel2.TabIndex = 7;
            sinLabel2.Text = "SIN";
            // 
            // sinCombo
            // 
            sinCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sinCombo.FormattingEnabled = true;
            sinCombo.Location = new Point(62, 533);
            sinCombo.Margin = new Padding(9, 8, 9, 8);
            sinCombo.Name = "sinCombo";
            sinCombo.Size = new Size(235, 23);
            sinCombo.TabIndex = 8;
            toolTips.SetToolTip(sinCombo, "Contains a list of SINs from registered students. Select a SIN of a student you wish to delete or update.");
            // 
            // removeAllRecordsButton
            // 
            removeAllRecordsButton.Location = new Point(358, 532);
            removeAllRecordsButton.Margin = new Padding(9, 8, 9, 8);
            removeAllRecordsButton.Name = "removeAllRecordsButton";
            removeAllRecordsButton.Size = new Size(175, 22);
            removeAllRecordsButton.TabIndex = 9;
            removeAllRecordsButton.Text = "Remove &All Records";
            toolTips.SetToolTip(removeAllRecordsButton, "Click this to remove all student records and reset the form to its default state.");
            removeAllRecordsButton.UseVisualStyleBackColor = true;
            removeAllRecordsButton.Click += RemoveAllRecords;
            // 
            // loadToServerButton
            // 
            loadToServerButton.Location = new Point(550, 532);
            loadToServerButton.Margin = new Padding(9, 8, 9, 8);
            loadToServerButton.Name = "loadToServerButton";
            loadToServerButton.Size = new Size(175, 22);
            loadToServerButton.TabIndex = 10;
            loadToServerButton.Text = "&Load Records To Server";
            toolTips.SetToolTip(loadToServerButton, "Click this to upload all registered student records from the form to an external JSON file.");
            loadToServerButton.UseVisualStyleBackColor = true;
            loadToServerButton.Click += LoadRecordsToServer;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(935, 532);
            exitButton.Margin = new Padding(9, 8, 9, 8);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 22);
            exitButton.TabIndex = 11;
            exitButton.Text = "E&xit";
            toolTips.SetToolTip(exitButton, "Click to exit the application.");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitApplication;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(0);
            menuStrip.Size = new Size(1034, 24);
            menuStrip.TabIndex = 12;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, recordToolStripMenuItem, deleteAllRecordsToolStripMenuItem, loadRecordsToServerToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(195, 22);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += RegisterStudent;
            // 
            // recordToolStripMenuItem
            // 
            recordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateRecordToolStripMenuItem, deleteRecordToolStripMenuItem });
            recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            recordToolStripMenuItem.Size = new Size(195, 22);
            recordToolStripMenuItem.Text = "Record";
            // 
            // updateRecordToolStripMenuItem
            // 
            updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            updateRecordToolStripMenuItem.Size = new Size(152, 22);
            updateRecordToolStripMenuItem.Text = "Update Record";
            updateRecordToolStripMenuItem.Click += UpdateRecord;
            // 
            // deleteRecordToolStripMenuItem
            // 
            deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            deleteRecordToolStripMenuItem.Size = new Size(152, 22);
            deleteRecordToolStripMenuItem.Text = "Delete Record";
            deleteRecordToolStripMenuItem.Click += DeleteRecord;
            // 
            // deleteAllRecordsToolStripMenuItem
            // 
            deleteAllRecordsToolStripMenuItem.Name = "deleteAllRecordsToolStripMenuItem";
            deleteAllRecordsToolStripMenuItem.Size = new Size(195, 22);
            deleteAllRecordsToolStripMenuItem.Text = "Delete All Records";
            deleteAllRecordsToolStripMenuItem.Click += RemoveAllRecords;
            // 
            // loadRecordsToServerToolStripMenuItem
            // 
            loadRecordsToServerToolStripMenuItem.Name = "loadRecordsToServerToolStripMenuItem";
            loadRecordsToServerToolStripMenuItem.Size = new Size(195, 22);
            loadRecordsToServerToolStripMenuItem.Text = "Load Records To Server";
            loadRecordsToServerToolStripMenuItem.Click += LoadRecordsToServer;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(195, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitApplication;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { readHelpToolStripMenuItem, technicalSupportToolStripMenuItem, aboutRegistrationAppToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // readHelpToolStripMenuItem
            // 
            readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            readHelpToolStripMenuItem.Size = new Size(198, 22);
            readHelpToolStripMenuItem.Text = "Read Help";
            readHelpToolStripMenuItem.Click += OpenHelpForm;
            // 
            // technicalSupportToolStripMenuItem
            // 
            technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            technicalSupportToolStripMenuItem.Size = new Size(198, 22);
            technicalSupportToolStripMenuItem.Text = "Technical Support";
            technicalSupportToolStripMenuItem.Click += OpenTechSupportForm;
            // 
            // aboutRegistrationAppToolStripMenuItem
            // 
            aboutRegistrationAppToolStripMenuItem.Name = "aboutRegistrationAppToolStripMenuItem";
            aboutRegistrationAppToolStripMenuItem.Size = new Size(198, 22);
            aboutRegistrationAppToolStripMenuItem.Text = "About Registration App";
            aboutRegistrationAppToolStripMenuItem.Click += OpenAboutForm;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = removeAllRecordsButton;
            ClientSize = new Size(1034, 565);
            Controls.Add(exitButton);
            Controls.Add(loadToServerButton);
            Controls.Add(removeAllRecordsButton);
            Controls.Add(sinCombo);
            Controls.Add(sinLabel2);
            Controls.Add(updateRecordButton);
            Controls.Add(deleteRecordButton);
            Controls.Add(studentDataGrid);
            Controls.Add(registerButton);
            Controls.Add(availableProgramsGroup);
            Controls.Add(checkButton);
            Controls.Add(studentInfoGroup);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration App";
            Click += RemoveAllRecords;
            studentInfoGroup.ResumeLayout(false);
            studentInfoGroup.PerformLayout();
            availableProgramsGroup.ResumeLayout(false);
            availableProgramsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGrid).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox studentInfoGroup;
        private Label gradeLabel;
        private Label admissionTestLabel;
        private Label emailLabel;
        private Label sinLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox emailInput;
        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private ComboBox gradeCombo;
        private ComboBox admissionTestCombo;
        private TextBox sinInput;
        private Button checkButton;
        private GroupBox availableProgramsGroup;
        private Label campusLocationLabel;
        private Label programsLabel;
        private ComboBox programsCombo;
        private ComboBox campusLocationCombo;
        private Label totalCostLabel;
        private Label studyPeriodLabel;
        private Button registerButton;
        private DataGridView studentDataGrid;
        private DataGridViewTextBoxColumn firstNameColumn;
        private DataGridViewTextBoxColumn lastNameColumn;
        private DataGridViewTextBoxColumn sinColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn gradeColumn;
        private DataGridViewTextBoxColumn admissionTestColumn;
        private DataGridViewTextBoxColumn campusLocationColumn;
        private DataGridViewTextBoxColumn programColumn;
        private Button deleteRecordButton;
        private Button updateRecordButton;
        private Label sinLabel2;
        private ComboBox sinCombo;
        private Button removeAllRecordsButton;
        private Button loadToServerButton;
        private Button exitButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem recordToolStripMenuItem;
        private ToolStripMenuItem updateRecordToolStripMenuItem;
        private ToolStripMenuItem deleteRecordToolStripMenuItem;
        private ToolStripMenuItem deleteAllRecordsToolStripMenuItem;
        private ToolStripMenuItem loadRecordsToServerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem readHelpToolStripMenuItem;
        private ToolStripMenuItem technicalSupportToolStripMenuItem;
        private ToolStripMenuItem aboutRegistrationAppToolStripMenuItem;
        private Label studyPeriodOutput;
        private Label totalCostOutput;
        private ToolTip toolTips;
    }
}