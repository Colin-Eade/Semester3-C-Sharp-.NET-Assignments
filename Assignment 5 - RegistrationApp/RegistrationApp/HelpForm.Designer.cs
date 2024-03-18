namespace RegistrationApp
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
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
            checkEligibilityNote = new Label();
            registerStudentNote = new Label();
            dataGridNote = new Label();
            deleteStudentNote = new Label();
            updateRecordNote = new Label();
            sinComboNote = new Label();
            deleteAllRecordsNote = new Label();
            loadRecordsNote = new Label();
            exitNote = new Label();
            panel1 = new Panel();
            menuStrip.SuspendLayout();
            studentInfoGroup.SuspendLayout();
            availableProgramsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(0);
            menuStrip.Size = new Size(1038, 24);
            menuStrip.TabIndex = 25;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, recordToolStripMenuItem, deleteAllRecordsToolStripMenuItem, loadRecordsToServerToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(195, 22);
            registerToolStripMenuItem.Text = "Register";
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
            // 
            // deleteRecordToolStripMenuItem
            // 
            deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            deleteRecordToolStripMenuItem.Size = new Size(152, 22);
            deleteRecordToolStripMenuItem.Text = "Delete Record";
            // 
            // deleteAllRecordsToolStripMenuItem
            // 
            deleteAllRecordsToolStripMenuItem.Name = "deleteAllRecordsToolStripMenuItem";
            deleteAllRecordsToolStripMenuItem.Size = new Size(195, 22);
            deleteAllRecordsToolStripMenuItem.Text = "Delete All Records";
            // 
            // loadRecordsToServerToolStripMenuItem
            // 
            loadRecordsToServerToolStripMenuItem.Name = "loadRecordsToServerToolStripMenuItem";
            loadRecordsToServerToolStripMenuItem.Size = new Size(195, 22);
            loadRecordsToServerToolStripMenuItem.Text = "Load Records To Server";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(195, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { readHelpToolStripMenuItem, technicalSupportToolStripMenuItem, aboutRegistrationAppToolStripMenuItem });
            helpToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // readHelpToolStripMenuItem
            // 
            readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            readHelpToolStripMenuItem.Size = new Size(198, 22);
            readHelpToolStripMenuItem.Text = "Read Help";
            // 
            // technicalSupportToolStripMenuItem
            // 
            technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            technicalSupportToolStripMenuItem.Size = new Size(198, 22);
            technicalSupportToolStripMenuItem.Text = "Technical Support";
            // 
            // aboutRegistrationAppToolStripMenuItem
            // 
            aboutRegistrationAppToolStripMenuItem.Name = "aboutRegistrationAppToolStripMenuItem";
            aboutRegistrationAppToolStripMenuItem.Size = new Size(198, 22);
            aboutRegistrationAppToolStripMenuItem.Text = "About Registration App";
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
            studentInfoGroup.Location = new Point(17, 30);
            studentInfoGroup.Margin = new Padding(9, 8, 9, 8);
            studentInfoGroup.Name = "studentInfoGroup";
            studentInfoGroup.Padding = new Padding(9, 8, 9, 8);
            studentInfoGroup.Size = new Size(1001, 98);
            studentInfoGroup.TabIndex = 13;
            studentInfoGroup.TabStop = false;
            studentInfoGroup.Text = "Student Information";
            // 
            // gradeCombo
            // 
            gradeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gradeCombo.Enabled = false;
            gradeCombo.FormattingEnabled = true;
            gradeCombo.Items.AddRange(new object[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            gradeCombo.Location = new Point(783, 58);
            gradeCombo.Margin = new Padding(9, 8, 9, 8);
            gradeCombo.Name = "gradeCombo";
            gradeCombo.Size = new Size(199, 23);
            gradeCombo.TabIndex = 11;
            // 
            // admissionTestCombo
            // 
            admissionTestCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            admissionTestCombo.Enabled = false;
            admissionTestCombo.FormattingEnabled = true;
            admissionTestCombo.Items.AddRange(new object[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            admissionTestCombo.Location = new Point(783, 28);
            admissionTestCombo.Margin = new Padding(9, 8, 9, 8);
            admissionTestCombo.Name = "admissionTestCombo";
            admissionTestCombo.Size = new Size(199, 23);
            admissionTestCombo.TabIndex = 10;
            // 
            // sinInput
            // 
            sinInput.Enabled = false;
            sinInput.Location = new Point(399, 28);
            sinInput.Margin = new Padding(9, 8, 9, 8);
            sinInput.MaxLength = 9;
            sinInput.Name = "sinInput";
            sinInput.Size = new Size(219, 23);
            sinInput.TabIndex = 5;
            // 
            // emailInput
            // 
            emailInput.Enabled = false;
            emailInput.Location = new Point(399, 58);
            emailInput.Margin = new Padding(9, 8, 9, 8);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(219, 23);
            emailInput.TabIndex = 7;
            // 
            // lastNameInput
            // 
            lastNameInput.Enabled = false;
            lastNameInput.Location = new Point(105, 58);
            lastNameInput.Margin = new Padding(9, 8, 9, 8);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(219, 23);
            lastNameInput.TabIndex = 3;
            // 
            // firstNameInput
            // 
            firstNameInput.Enabled = false;
            firstNameInput.Location = new Point(105, 28);
            firstNameInput.Margin = new Padding(9, 8, 9, 8);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(219, 23);
            firstNameInput.TabIndex = 1;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new Point(641, 65);
            gradeLabel.Margin = new Padding(9, 8, 9, 8);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(106, 15);
            gradeLabel.TabIndex = 9;
            gradeLabel.Text = "High School Grade";
            // 
            // admissionTestLabel
            // 
            admissionTestLabel.AutoSize = true;
            admissionTestLabel.Location = new Point(641, 35);
            admissionTestLabel.Margin = new Padding(9, 8, 9, 8);
            admissionTestLabel.Name = "admissionTestLabel";
            admissionTestLabel.Size = new Size(118, 15);
            admissionTestLabel.TabIndex = 8;
            admissionTestLabel.Text = "Admission Test Score";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(347, 65);
            emailLabel.Margin = new Padding(9, 8, 9, 8);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // sinLabel
            // 
            sinLabel.AutoSize = true;
            sinLabel.Location = new Point(347, 35);
            sinLabel.Margin = new Padding(9, 8, 9, 8);
            sinLabel.Name = "sinLabel";
            sinLabel.Size = new Size(25, 15);
            sinLabel.TabIndex = 4;
            sinLabel.Text = "SIN";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(24, 65);
            lastNameLabel.Margin = new Padding(9, 8, 9, 8);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(24, 35);
            firstNameLabel.Margin = new Padding(9, 8, 9, 8);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // checkButton
            // 
            checkButton.Enabled = false;
            checkButton.Location = new Point(17, 142);
            checkButton.Margin = new Padding(9, 8, 9, 8);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(131, 22);
            checkButton.TabIndex = 14;
            checkButton.Text = "&Check";
            checkButton.UseVisualStyleBackColor = true;
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
            availableProgramsGroup.Location = new Point(17, 179);
            availableProgramsGroup.Margin = new Padding(9, 8, 9, 8);
            availableProgramsGroup.Name = "availableProgramsGroup";
            availableProgramsGroup.Padding = new Padding(9, 8, 9, 8);
            availableProgramsGroup.Size = new Size(1001, 90);
            availableProgramsGroup.TabIndex = 15;
            availableProgramsGroup.TabStop = false;
            availableProgramsGroup.Text = "Available Programs";
            // 
            // totalCostOutput
            // 
            totalCostOutput.AutoSize = true;
            totalCostOutput.Location = new Point(916, 62);
            totalCostOutput.Margin = new Padding(9, 8, 9, 8);
            totalCostOutput.Name = "totalCostOutput";
            totalCostOutput.Size = new Size(34, 15);
            totalCostOutput.TabIndex = 7;
            totalCostOutput.Text = "$0.00";
            // 
            // studyPeriodOutput
            // 
            studyPeriodOutput.AutoSize = true;
            studyPeriodOutput.Location = new Point(916, 31);
            studyPeriodOutput.Margin = new Padding(9, 8, 9, 8);
            studyPeriodOutput.Name = "studyPeriodOutput";
            studyPeriodOutput.Size = new Size(28, 15);
            studyPeriodOutput.TabIndex = 6;
            studyPeriodOutput.Text = "0.00";
            // 
            // programsCombo
            // 
            programsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            programsCombo.Enabled = false;
            programsCombo.FormattingEnabled = true;
            programsCombo.Location = new Point(459, 38);
            programsCombo.Margin = new Padding(9, 8, 9, 8);
            programsCombo.Name = "programsCombo";
            programsCombo.Size = new Size(307, 23);
            programsCombo.TabIndex = 3;
            // 
            // campusLocationCombo
            // 
            campusLocationCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            campusLocationCombo.Enabled = false;
            campusLocationCombo.FormattingEnabled = true;
            campusLocationCombo.Location = new Point(143, 38);
            campusLocationCombo.Margin = new Padding(9, 8, 9, 8);
            campusLocationCombo.Name = "campusLocationCombo";
            campusLocationCombo.Size = new Size(219, 23);
            campusLocationCombo.TabIndex = 1;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(824, 62);
            totalCostLabel.Margin = new Padding(9, 8, 9, 8);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(59, 15);
            totalCostLabel.TabIndex = 5;
            totalCostLabel.Text = "Total Cost";
            // 
            // studyPeriodLabel
            // 
            studyPeriodLabel.AutoSize = true;
            studyPeriodLabel.Location = new Point(824, 31);
            studyPeriodLabel.Margin = new Padding(9, 8, 9, 8);
            studyPeriodLabel.Name = "studyPeriodLabel";
            studyPeriodLabel.Size = new Size(74, 15);
            studyPeriodLabel.TabIndex = 4;
            studyPeriodLabel.Text = "Study Period";
            // 
            // programsLabel
            // 
            programsLabel.AutoSize = true;
            programsLabel.Location = new Point(385, 45);
            programsLabel.Margin = new Padding(9, 8, 9, 8);
            programsLabel.Name = "programsLabel";
            programsLabel.Size = new Size(58, 15);
            programsLabel.TabIndex = 2;
            programsLabel.Text = "Programs";
            // 
            // campusLocationLabel
            // 
            campusLocationLabel.AutoSize = true;
            campusLocationLabel.Location = new Point(24, 45);
            campusLocationLabel.Margin = new Padding(9, 8, 9, 8);
            campusLocationLabel.Name = "campusLocationLabel";
            campusLocationLabel.Size = new Size(100, 15);
            campusLocationLabel.TabIndex = 0;
            campusLocationLabel.Text = "Campus Location";
            // 
            // registerButton
            // 
            registerButton.Enabled = false;
            registerButton.Location = new Point(17, 284);
            registerButton.Margin = new Padding(9, 8, 9, 8);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(131, 22);
            registerButton.TabIndex = 16;
            registerButton.Text = "&Register Student";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // studentDataGrid
            // 
            studentDataGrid.AllowUserToAddRows = false;
            studentDataGrid.AllowUserToDeleteRows = false;
            studentDataGrid.AllowUserToResizeRows = false;
            studentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGrid.Columns.AddRange(new DataGridViewColumn[] { firstNameColumn, lastNameColumn, sinColumn, emailColumn, gradeColumn, admissionTestColumn, campusLocationColumn, programColumn });
            studentDataGrid.Enabled = false;
            studentDataGrid.Location = new Point(15, 320);
            studentDataGrid.Margin = new Padding(9, 8, 9, 8);
            studentDataGrid.Name = "studentDataGrid";
            studentDataGrid.ReadOnly = true;
            studentDataGrid.RowHeadersVisible = false;
            studentDataGrid.RowHeadersWidth = 51;
            studentDataGrid.RowTemplate.Height = 29;
            studentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentDataGrid.Size = new Size(1003, 166);
            studentDataGrid.TabIndex = 17;
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
            deleteRecordButton.Enabled = false;
            deleteRecordButton.Location = new Point(18, 601);
            deleteRecordButton.Margin = new Padding(9, 8, 9, 8);
            deleteRecordButton.Name = "deleteRecordButton";
            deleteRecordButton.Size = new Size(131, 22);
            deleteRecordButton.TabIndex = 18;
            deleteRecordButton.Text = "&Delete Record";
            deleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // updateRecordButton
            // 
            updateRecordButton.Enabled = false;
            updateRecordButton.Location = new Point(166, 601);
            updateRecordButton.Margin = new Padding(9, 8, 9, 8);
            updateRecordButton.Name = "updateRecordButton";
            updateRecordButton.Size = new Size(131, 22);
            updateRecordButton.TabIndex = 19;
            updateRecordButton.Text = "&Update Record";
            updateRecordButton.UseVisualStyleBackColor = true;
            // 
            // sinLabel2
            // 
            sinLabel2.AutoSize = true;
            sinLabel2.Location = new Point(16, 724);
            sinLabel2.Margin = new Padding(9, 8, 9, 8);
            sinLabel2.Name = "sinLabel2";
            sinLabel2.Size = new Size(25, 15);
            sinLabel2.TabIndex = 20;
            sinLabel2.Text = "SIN";
            // 
            // sinCombo
            // 
            sinCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sinCombo.Enabled = false;
            sinCombo.FormattingEnabled = true;
            sinCombo.Location = new Point(61, 721);
            sinCombo.Margin = new Padding(9, 8, 9, 8);
            sinCombo.Name = "sinCombo";
            sinCombo.Size = new Size(235, 23);
            sinCombo.TabIndex = 21;
            // 
            // removeAllRecordsButton
            // 
            removeAllRecordsButton.Enabled = false;
            removeAllRecordsButton.Location = new Point(357, 720);
            removeAllRecordsButton.Margin = new Padding(9, 8, 9, 8);
            removeAllRecordsButton.Name = "removeAllRecordsButton";
            removeAllRecordsButton.Size = new Size(175, 22);
            removeAllRecordsButton.TabIndex = 22;
            removeAllRecordsButton.Text = "Remove &All Records";
            removeAllRecordsButton.UseVisualStyleBackColor = true;
            // 
            // loadToServerButton
            // 
            loadToServerButton.Enabled = false;
            loadToServerButton.Location = new Point(549, 720);
            loadToServerButton.Margin = new Padding(9, 8, 9, 8);
            loadToServerButton.Name = "loadToServerButton";
            loadToServerButton.Size = new Size(175, 22);
            loadToServerButton.TabIndex = 23;
            loadToServerButton.Text = "Load Records To Server";
            loadToServerButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Enabled = false;
            exitButton.Location = new Point(934, 720);
            exitButton.Margin = new Padding(9, 8, 9, 8);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(82, 22);
            exitButton.TabIndex = 24;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // checkEligibilityNote
            // 
            checkEligibilityNote.AutoSize = true;
            checkEligibilityNote.BackColor = SystemColors.Info;
            checkEligibilityNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkEligibilityNote.Location = new Point(165, 135);
            checkEligibilityNote.Name = "checkEligibilityNote";
            checkEligibilityNote.Size = new Size(843, 45);
            checkEligibilityNote.TabIndex = 26;
            checkEligibilityNote.Text = resources.GetString("checkEligibilityNote.Text");
            // 
            // registerStudentNote
            // 
            registerStudentNote.AutoSize = true;
            registerStudentNote.BackColor = SystemColors.Info;
            registerStudentNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerStudentNote.Location = new Point(160, 278);
            registerStudentNote.Name = "registerStudentNote";
            registerStudentNote.Size = new Size(847, 30);
            registerStudentNote.TabIndex = 27;
            registerStudentNote.Text = resources.GetString("registerStudentNote.Text");
            // 
            // dataGridNote
            // 
            dataGridNote.AutoSize = true;
            dataGridNote.BackColor = SystemColors.Info;
            dataGridNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridNote.Location = new Point(95, 494);
            dataGridNote.Name = "dataGridNote";
            dataGridNote.Size = new Size(866, 15);
            dataGridNote.TabIndex = 28;
            dataGridNote.Text = "This table is populated with registered students. A user can also select a row on the table to populate the Student Information fields at the top of the form.";
            // 
            // deleteStudentNote
            // 
            deleteStudentNote.AutoSize = true;
            deleteStudentNote.BackColor = SystemColors.Info;
            deleteStudentNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteStudentNote.Location = new Point(19, 533);
            deleteStudentNote.Name = "deleteStudentNote";
            deleteStudentNote.Size = new Size(130, 60);
            deleteStudentNote.TabIndex = 29;
            deleteStudentNote.Text = "Deletes the record of \r\nthe student selected \r\nfrom the SIN \r\ndropdown.";
            // 
            // updateRecordNote
            // 
            updateRecordNote.AutoSize = true;
            updateRecordNote.BackColor = SystemColors.Info;
            updateRecordNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateRecordNote.Location = new Point(309, 601);
            updateRecordNote.Name = "updateRecordNote";
            updateRecordNote.Size = new Size(502, 30);
            updateRecordNote.TabIndex = 30;
            updateRecordNote.Text = "Updates the record of a student selected from the SIN dropdown. Takes the information \r\nfrom the Student Information fields to update the selected student record.";
            // 
            // sinComboNote
            // 
            sinComboNote.AutoSize = true;
            sinComboNote.BackColor = SystemColors.Info;
            sinComboNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sinComboNote.Location = new Point(12, 653);
            sinComboNote.Name = "sinComboNote";
            sinComboNote.Size = new Size(303, 60);
            sinComboNote.TabIndex = 31;
            sinComboNote.Text = "This dropdown is populated with SINs of registered\r\n students. The \"Delete Record\" and \"Update Record\"\r\n button perform their actions based on the student\r\n SIN selected here.";
            // 
            // deleteAllRecordsNote
            // 
            deleteAllRecordsNote.AutoSize = true;
            deleteAllRecordsNote.BackColor = SystemColors.Info;
            deleteAllRecordsNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteAllRecordsNote.Location = new Point(364, 667);
            deleteAllRecordsNote.Name = "deleteAllRecordsNote";
            deleteAllRecordsNote.Size = new Size(156, 45);
            deleteAllRecordsNote.TabIndex = 32;
            deleteAllRecordsNote.Text = "Deletes all student records\r\n and resets the form to its \r\ndefault state.";
            // 
            // loadRecordsNote
            // 
            loadRecordsNote.AutoSize = true;
            loadRecordsNote.BackColor = SystemColors.Info;
            loadRecordsNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loadRecordsNote.Location = new Point(549, 652);
            loadRecordsNote.Name = "loadRecordsNote";
            loadRecordsNote.Size = new Size(209, 60);
            loadRecordsNote.TabIndex = 33;
            loadRecordsNote.Text = "Saves all student records to an \r\nexternal JSON file, clears all records \r\non the form and resets the form to\r\n its default state.";
            // 
            // exitNote
            // 
            exitNote.AutoSize = true;
            exitNote.BackColor = SystemColors.Info;
            exitNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitNote.Location = new Point(896, 697);
            exitNote.Name = "exitNote";
            exitNote.Size = new Size(129, 15);
            exitNote.TabIndex = 34;
            exitNote.Text = "Closes the application.";
            // 
            // panel1
            // 
            panel1.Controls.Add(exitNote);
            panel1.Controls.Add(loadRecordsNote);
            panel1.Controls.Add(deleteAllRecordsNote);
            panel1.Controls.Add(sinComboNote);
            panel1.Controls.Add(updateRecordNote);
            panel1.Controls.Add(deleteStudentNote);
            panel1.Controls.Add(dataGridNote);
            panel1.Controls.Add(registerStudentNote);
            panel1.Controls.Add(checkEligibilityNote);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(loadToServerButton);
            panel1.Controls.Add(removeAllRecordsButton);
            panel1.Controls.Add(sinCombo);
            panel1.Controls.Add(sinLabel2);
            panel1.Controls.Add(updateRecordButton);
            panel1.Controls.Add(deleteRecordButton);
            panel1.Controls.Add(studentDataGrid);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(availableProgramsGroup);
            panel1.Controls.Add(checkButton);
            panel1.Controls.Add(studentInfoGroup);
            panel1.Controls.Add(menuStrip);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 763);
            panel1.TabIndex = 35;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 761);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            studentInfoGroup.ResumeLayout(false);
            studentInfoGroup.PerformLayout();
            availableProgramsGroup.ResumeLayout(false);
            availableProgramsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem recordToolStripMenuItem;
        private ToolStripMenuItem updateRecordToolStripMenuItem;
        private ToolStripMenuItem deleteRecordToolStripMenuItem;
        private ToolStripMenuItem deleteAllRecordsToolStripMenuItem;
        private ToolStripMenuItem loadRecordsToServerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem readHelpToolStripMenuItem;
        private ToolStripMenuItem technicalSupportToolStripMenuItem;
        private ToolStripMenuItem aboutRegistrationAppToolStripMenuItem;
        private GroupBox studentInfoGroup;
        private ComboBox gradeCombo;
        private ComboBox admissionTestCombo;
        private TextBox sinInput;
        private TextBox emailInput;
        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private Label gradeLabel;
        private Label admissionTestLabel;
        private Label emailLabel;
        private Label sinLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button checkButton;
        private GroupBox availableProgramsGroup;
        private Label totalCostOutput;
        private Label studyPeriodOutput;
        private ComboBox programsCombo;
        private ComboBox campusLocationCombo;
        private Label totalCostLabel;
        private Label studyPeriodLabel;
        private Label programsLabel;
        private Label campusLocationLabel;
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
        private Label checkEligibilityNote;
        private Label registerStudentNote;
        private Label dataGridNote;
        private Label deleteStudentNote;
        private Label updateRecordNote;
        private Label sinComboNote;
        private Label deleteAllRecordsNote;
        private Label loadRecordsNote;
        private Label exitNote;
        private Panel panel1;
    }
}