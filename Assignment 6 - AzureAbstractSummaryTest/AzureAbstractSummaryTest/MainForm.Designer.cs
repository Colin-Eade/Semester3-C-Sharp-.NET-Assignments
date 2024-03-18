namespace AzureAbstractSummaryTest
{
    partial class MainForm
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
            userInput = new TextBox();
            summarizeButton = new Button();
            summaryOutput = new TextBox();
            copyToClipboardButton = new Button();
            resetButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            exitButton = new Button();
            toolTips = new ToolTip(components);
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userInput
            // 
            userInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userInput.Location = new Point(5, 5);
            userInput.Margin = new Padding(5);
            userInput.Multiline = true;
            userInput.Name = "userInput";
            userInput.ScrollBars = ScrollBars.Vertical;
            userInput.Size = new Size(746, 225);
            userInput.TabIndex = 0;
            userInput.Text = "Enter text to summarize";
            toolTips.SetToolTip(userInput, "Type or paste text you want summarized here.");
            userInput.Click += userInput_Click;
            // 
            // summarizeButton
            // 
            summarizeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            summarizeButton.Location = new Point(14, 495);
            summarizeButton.Margin = new Padding(5);
            summarizeButton.Name = "summarizeButton";
            summarizeButton.Size = new Size(130, 25);
            summarizeButton.TabIndex = 0;
            summarizeButton.Text = "&Summarize";
            toolTips.SetToolTip(summarizeButton, "Click to summarize your text input.");
            summarizeButton.UseVisualStyleBackColor = true;
            summarizeButton.Click += summarizeButton_Click;
            // 
            // summaryOutput
            // 
            summaryOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            summaryOutput.Location = new Point(5, 240);
            summaryOutput.Margin = new Padding(5);
            summaryOutput.Multiline = true;
            summaryOutput.Name = "summaryOutput";
            summaryOutput.ReadOnly = true;
            summaryOutput.ScrollBars = ScrollBars.Vertical;
            summaryOutput.Size = new Size(746, 226);
            summaryOutput.TabIndex = 1;
            summaryOutput.Text = "Summary";
            toolTips.SetToolTip(summaryOutput, "A summary of your text input will display here after the \"Summary\" button is clicked");
            // 
            // copyToClipboardButton
            // 
            copyToClipboardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            copyToClipboardButton.Location = new Point(154, 495);
            copyToClipboardButton.Margin = new Padding(5);
            copyToClipboardButton.Name = "copyToClipboardButton";
            copyToClipboardButton.Size = new Size(130, 25);
            copyToClipboardButton.TabIndex = 1;
            copyToClipboardButton.Text = "&Copy to Clipboard";
            toolTips.SetToolTip(copyToClipboardButton, "Click to copy the summary to your clipboard.");
            copyToClipboardButton.UseVisualStyleBackColor = true;
            copyToClipboardButton.Click += copyToClipboardButton_Click;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            resetButton.Location = new Point(294, 495);
            resetButton.Margin = new Padding(5);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(130, 25);
            resetButton.TabIndex = 2;
            resetButton.Text = "&Reset";
            toolTips.SetToolTip(resetButton, "Click to reset the form.");
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(summaryOutput, 0, 1);
            tableLayoutPanel.Controls.Add(userInput, 0, 0);
            tableLayoutPanel.Location = new Point(14, 14);
            tableLayoutPanel.Margin = new Padding(5);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(756, 471);
            tableLayoutPanel.TabIndex = 4;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitButton.Location = new Point(640, 495);
            exitButton.Margin = new Padding(5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(130, 25);
            exitButton.TabIndex = 3;
            exitButton.Text = "E&xit";
            toolTips.SetToolTip(exitButton, "Click to exit the application.");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AcceptButton = summarizeButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(784, 531);
            Controls.Add(exitButton);
            Controls.Add(tableLayoutPanel);
            Controls.Add(resetButton);
            Controls.Add(copyToClipboardButton);
            Controls.Add(summarizeButton);
            MinimumSize = new Size(800, 570);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Azure AI Text Summarizer";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox userInput;
        private Button summarizeButton;
        private TextBox summaryOutput;
        private Button copyToClipboardButton;
        private Button resetButton;
        private TableLayoutPanel tableLayoutPanel;
        private Button exitButton;
        private ToolTip toolTips;
    }
}
