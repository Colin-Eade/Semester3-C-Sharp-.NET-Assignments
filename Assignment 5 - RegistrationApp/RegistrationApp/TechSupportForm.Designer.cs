namespace RegistrationApp
{
    partial class TechSupportForm
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
            contactInfoGroup = new GroupBox();
            emailText = new Label();
            idText = new Label();
            nameText = new Label();
            emailLabel = new Label();
            idLabel = new Label();
            nameLabel = new Label();
            closeButton = new Button();
            contactInfoGroup.SuspendLayout();
            SuspendLayout();
            // 
            // contactInfoGroup
            // 
            contactInfoGroup.Controls.Add(emailText);
            contactInfoGroup.Controls.Add(idText);
            contactInfoGroup.Controls.Add(nameText);
            contactInfoGroup.Controls.Add(emailLabel);
            contactInfoGroup.Controls.Add(idLabel);
            contactInfoGroup.Controls.Add(nameLabel);
            contactInfoGroup.Location = new Point(19, 19);
            contactInfoGroup.Margin = new Padding(10);
            contactInfoGroup.Name = "contactInfoGroup";
            contactInfoGroup.Padding = new Padding(10);
            contactInfoGroup.Size = new Size(400, 140);
            contactInfoGroup.TabIndex = 0;
            contactInfoGroup.TabStop = false;
            contactInfoGroup.Text = "Contact Information";
            // 
            // emailText
            // 
            emailText.AutoSize = true;
            emailText.Location = new Point(79, 106);
            emailText.Margin = new Padding(10);
            emailText.Name = "emailText";
            emailText.Size = new Size(123, 15);
            emailText.TabIndex = 5;
            emailText.Text = "colin.eade@dcmail.ca";
            // 
            // idText
            // 
            idText.AutoSize = true;
            idText.Location = new Point(79, 71);
            idText.Margin = new Padding(10);
            idText.Name = "idText";
            idText.Size = new Size(61, 15);
            idText.TabIndex = 4;
            idText.Text = "100329105";
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Location = new Point(85, 36);
            nameText.Margin = new Padding(10);
            nameText.Name = "nameText";
            nameText.Size = new Size(63, 15);
            nameText.TabIndex = 3;
            nameText.Text = "Colin Eade";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(20, 106);
            emailLabel.Margin = new Padding(10);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(20, 71);
            idLabel.Margin = new Padding(10);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(20, 36);
            nameLabel.Margin = new Padding(10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name: ";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(340, 179);
            closeButton.Margin = new Padding(10);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += ExitApplication;
            // 
            // TechSupportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(434, 211);
            Controls.Add(closeButton);
            Controls.Add(contactInfoGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TechSupportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Technical Support";
            contactInfoGroup.ResumeLayout(false);
            contactInfoGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox contactInfoGroup;
        private Label nameLabel;
        private Label emailText;
        private Label idText;
        private Label nameText;
        private Label emailLabel;
        private Label idLabel;
        private Button closeButton;
    }
}