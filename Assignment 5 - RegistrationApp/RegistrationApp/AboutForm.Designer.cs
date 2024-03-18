namespace RegistrationApp
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            aboutGroup = new GroupBox();
            closeButton = new Button();
            aboutText = new Label();
            aboutGroup.SuspendLayout();
            SuspendLayout();
            // 
            // aboutGroup
            // 
            aboutGroup.Controls.Add(aboutText);
            aboutGroup.Location = new Point(19, 19);
            aboutGroup.Margin = new Padding(10);
            aboutGroup.Name = "aboutGroup";
            aboutGroup.Padding = new Padding(10);
            aboutGroup.Size = new Size(571, 90);
            aboutGroup.TabIndex = 0;
            aboutGroup.TabStop = false;
            aboutGroup.Text = "Registration Application";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(515, 129);
            closeButton.Margin = new Padding(10);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += ExitApplication;
            // 
            // aboutText
            // 
            aboutText.AutoSize = true;
            aboutText.Location = new Point(20, 36);
            aboutText.Margin = new Padding(10);
            aboutText.Name = "aboutText";
            aboutText.Size = new Size(536, 30);
            aboutText.TabIndex = 1;
            aboutText.Text = resources.GetString("aboutText.Text");
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 166);
            Controls.Add(closeButton);
            Controls.Add(aboutGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            aboutGroup.ResumeLayout(false);
            aboutGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox aboutGroup;
        private Button closeButton;
        private Label aboutText;
    }
}