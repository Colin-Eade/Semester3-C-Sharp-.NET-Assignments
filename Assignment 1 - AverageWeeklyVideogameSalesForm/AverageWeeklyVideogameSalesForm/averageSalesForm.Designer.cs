namespace AverageWeeklyVideogameSalesForm
{
    partial class averageSalesForm
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
            resetButton = new Button();
            exitButton = new Button();
            enterButton = new Button();
            outputLabel = new Label();
            entryList = new ListBox();
            salesLabel = new Label();
            salesInput = new TextBox();
            dayLabel = new Label();
            formtoolTips = new ToolTip(components);
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(162, 401);
            resetButton.Margin = new Padding(3, 4, 3, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(126, 31);
            resetButton.TabIndex = 6;
            resetButton.Text = "&Reset";
            formtoolTips.SetToolTip(resetButton, "Click to reset the form to the initial state (ALT+ R) or (ESC)");
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(311, 401);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 31);
            exitButton.TabIndex = 7;
            exitButton.Text = "E&xit";
            formtoolTips.SetToolTip(exitButton, "Click to exit the application (ALT + X)");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(14, 401);
            enterButton.Margin = new Padding(3, 4, 3, 4);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(126, 31);
            enterButton.TabIndex = 5;
            enterButton.Text = "&Enter";
            formtoolTips.SetToolTip(enterButton, "Click to enter a daily sales value into the list (ALT + E) or (ENTER)");
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.Fixed3D;
            outputLabel.Location = new Point(14, 360);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(423, 31);
            outputLabel.TabIndex = 4;
            outputLabel.Text = "Average Videogame Sales: ";
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            formtoolTips.SetToolTip(outputLabel, "A running total of the average sales will display here");
            // 
            // entryList
            // 
            entryList.FormattingEnabled = true;
            entryList.ItemHeight = 20;
            entryList.Location = new Point(14, 51);
            entryList.Margin = new Padding(3, 4, 3, 4);
            entryList.Name = "entryList";
            entryList.Size = new Size(422, 304);
            entryList.TabIndex = 3;
            formtoolTips.SetToolTip(entryList, "Daily sales will show up in a list here");
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Location = new Point(14, 16);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(124, 20);
            salesLabel.TabIndex = 0;
            salesLabel.Text = "Videogame Sales";
            // 
            // salesInput
            // 
            salesInput.Location = new Point(144, 12);
            salesInput.Margin = new Padding(3, 4, 3, 4);
            salesInput.Name = "salesInput";
            salesInput.Size = new Size(236, 27);
            salesInput.TabIndex = 1;
            formtoolTips.SetToolTip(salesInput, "Input a numeric value for the daily sales");
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new Point(387, 16);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(48, 20);
            dayLabel.TabIndex = 2;
            dayLabel.Text = "Day #";
            formtoolTips.SetToolTip(dayLabel, "Day of the week");
            // 
            // averageSalesForm
            // 
            AcceptButton = enterButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = resetButton;
            ClientSize = new Size(450, 448);
            Controls.Add(dayLabel);
            Controls.Add(salesInput);
            Controls.Add(salesLabel);
            Controls.Add(entryList);
            Controls.Add(outputLabel);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(enterButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "averageSalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Average Weekly Videogame Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetButton;
        private Button exitButton;
        private Button enterButton;
        private Label outputLabel;
        private ListBox entryList;
        private Label salesLabel;
        private TextBox salesInput;
        private Label dayLabel;
        private ToolTip formtoolTips;
    }
}