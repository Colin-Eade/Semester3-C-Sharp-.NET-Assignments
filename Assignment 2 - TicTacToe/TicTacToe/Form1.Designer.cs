namespace TicTacToe
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
            gameSetupGroup = new GroupBox();
            player2SymbolText = new TextBox();
            player1SymbolText = new TextBox();
            player2NameText = new TextBox();
            player1NameText = new TextBox();
            player2SymbolLabel = new Label();
            player1SymbolLabel = new Label();
            player2NameLabel = new Label();
            player1NameLabel = new Label();
            gameAreaGroup = new GroupBox();
            resetButton = new Button();
            continueButton = new Button();
            startButton = new Button();
            nextTurnNameText = new TextBox();
            nextTurnLabel = new Label();
            button33 = new Button();
            button32 = new Button();
            button31 = new Button();
            button23 = new Button();
            button22 = new Button();
            button21 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            gameStatsGroup = new GroupBox();
            winnerNameText = new TextBox();
            winnerLabel = new Label();
            resultsList = new ListBox();
            toolTips = new ToolTip(components);
            gameSetupGroup.SuspendLayout();
            gameAreaGroup.SuspendLayout();
            gameStatsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // gameSetupGroup
            // 
            gameSetupGroup.Controls.Add(player2SymbolText);
            gameSetupGroup.Controls.Add(player1SymbolText);
            gameSetupGroup.Controls.Add(player2NameText);
            gameSetupGroup.Controls.Add(player1NameText);
            gameSetupGroup.Controls.Add(player2SymbolLabel);
            gameSetupGroup.Controls.Add(player1SymbolLabel);
            gameSetupGroup.Controls.Add(player2NameLabel);
            gameSetupGroup.Controls.Add(player1NameLabel);
            gameSetupGroup.Location = new Point(11, 12);
            gameSetupGroup.Name = "gameSetupGroup";
            gameSetupGroup.Size = new Size(685, 109);
            gameSetupGroup.TabIndex = 0;
            gameSetupGroup.TabStop = false;
            gameSetupGroup.Text = "Game Setup";
            // 
            // player2SymbolText
            // 
            player2SymbolText.Location = new Point(558, 61);
            player2SymbolText.Name = "player2SymbolText";
            player2SymbolText.Size = new Size(94, 27);
            player2SymbolText.TabIndex = 7;
            toolTips.SetToolTip(player2SymbolText, "Enter a symbol for Player 2");
            // 
            // player1SymbolText
            // 
            player1SymbolText.Location = new Point(558, 25);
            player1SymbolText.Name = "player1SymbolText";
            player1SymbolText.Size = new Size(94, 27);
            player1SymbolText.TabIndex = 3;
            toolTips.SetToolTip(player1SymbolText, "Enter a symbol for Player 1");
            // 
            // player2NameText
            // 
            player2NameText.Location = new Point(139, 61);
            player2NameText.Name = "player2NameText";
            player2NameText.Size = new Size(217, 27);
            player2NameText.TabIndex = 5;
            toolTips.SetToolTip(player2NameText, "Enter a name for Player 2");
            // 
            // player1NameText
            // 
            player1NameText.Location = new Point(139, 25);
            player1NameText.Name = "player1NameText";
            player1NameText.Size = new Size(217, 27);
            player1NameText.TabIndex = 1;
            toolTips.SetToolTip(player1NameText, "Enter a name for Player 1");
            // 
            // player2SymbolLabel
            // 
            player2SymbolLabel.AutoSize = true;
            player2SymbolLabel.Location = new Point(434, 64);
            player2SymbolLabel.Name = "player2SymbolLabel";
            player2SymbolLabel.Size = new Size(118, 20);
            player2SymbolLabel.TabIndex = 6;
            player2SymbolLabel.Text = "Player 2 Symbol:";
            // 
            // player1SymbolLabel
            // 
            player1SymbolLabel.AutoSize = true;
            player1SymbolLabel.Location = new Point(434, 28);
            player1SymbolLabel.Name = "player1SymbolLabel";
            player1SymbolLabel.Size = new Size(118, 20);
            player1SymbolLabel.TabIndex = 2;
            player1SymbolLabel.Text = "Player 1 Symbol:";
            // 
            // player2NameLabel
            // 
            player2NameLabel.AutoSize = true;
            player2NameLabel.Location = new Point(26, 64);
            player2NameLabel.Name = "player2NameLabel";
            player2NameLabel.Size = new Size(108, 20);
            player2NameLabel.TabIndex = 4;
            player2NameLabel.Text = "Player 2 Name:";
            // 
            // player1NameLabel
            // 
            player1NameLabel.AutoSize = true;
            player1NameLabel.Location = new Point(26, 28);
            player1NameLabel.Name = "player1NameLabel";
            player1NameLabel.Size = new Size(108, 20);
            player1NameLabel.TabIndex = 0;
            player1NameLabel.Text = "Player 1 Name:";
            // 
            // gameAreaGroup
            // 
            gameAreaGroup.Controls.Add(resetButton);
            gameAreaGroup.Controls.Add(continueButton);
            gameAreaGroup.Controls.Add(startButton);
            gameAreaGroup.Controls.Add(nextTurnNameText);
            gameAreaGroup.Controls.Add(nextTurnLabel);
            gameAreaGroup.Controls.Add(button33);
            gameAreaGroup.Controls.Add(button32);
            gameAreaGroup.Controls.Add(button31);
            gameAreaGroup.Controls.Add(button23);
            gameAreaGroup.Controls.Add(button22);
            gameAreaGroup.Controls.Add(button21);
            gameAreaGroup.Controls.Add(button13);
            gameAreaGroup.Controls.Add(button12);
            gameAreaGroup.Controls.Add(button11);
            gameAreaGroup.Location = new Point(11, 128);
            gameAreaGroup.Name = "gameAreaGroup";
            gameAreaGroup.Size = new Size(395, 376);
            gameAreaGroup.TabIndex = 1;
            gameAreaGroup.TabStop = false;
            gameAreaGroup.Text = "Game Area";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(294, 249);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 11;
            resetButton.Text = "Reset";
            toolTips.SetToolTip(resetButton, "Click to reset the form to the initial state ");
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(294, 153);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(94, 29);
            continueButton.TabIndex = 10;
            continueButton.Text = "Continue";
            toolTips.SetToolTip(continueButton, "Click to play a new game and keep your stats");
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(294, 57);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 9;
            startButton.Text = "Start";
            toolTips.SetToolTip(startButton, "Click to start the game");
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // nextTurnNameText
            // 
            nextTurnNameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nextTurnNameText.Location = new Point(107, 331);
            nextTurnNameText.Name = "nextTurnNameText";
            nextTurnNameText.ReadOnly = true;
            nextTurnNameText.Size = new Size(157, 27);
            nextTurnNameText.TabIndex = 13;
            toolTips.SetToolTip(nextTurnNameText, "Name of the player who is up next");
            // 
            // nextTurnLabel
            // 
            nextTurnLabel.AutoSize = true;
            nextTurnLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nextTurnLabel.Location = new Point(21, 333);
            nextTurnLabel.Name = "nextTurnLabel";
            nextTurnLabel.Size = new Size(83, 20);
            nextTurnLabel.TabIndex = 12;
            nextTurnLabel.Text = "Next Turn:";
            // 
            // button33
            // 
            button33.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button33.Location = new Point(198, 219);
            button33.Name = "button33";
            button33.Size = new Size(90, 91);
            button33.TabIndex = 8;
            toolTips.SetToolTip(button33, " Click to add the symbol of the player currently on their turn");
            button33.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            button32.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button32.Location = new Point(102, 219);
            button32.Name = "button32";
            button32.Size = new Size(90, 91);
            button32.TabIndex = 7;
            toolTips.SetToolTip(button32, " Click to add the symbol of the player currently on their turn");
            button32.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            button31.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button31.Location = new Point(6, 219);
            button31.Name = "button31";
            button31.Size = new Size(90, 91);
            button31.TabIndex = 6;
            toolTips.SetToolTip(button31, " Click to add the symbol of the player currently on their turn");
            button31.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button23.Location = new Point(198, 123);
            button23.Name = "button23";
            button23.Size = new Size(90, 91);
            button23.TabIndex = 5;
            toolTips.SetToolTip(button23, " Click to add the symbol of the player currently on their turn");
            button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button22.Location = new Point(102, 123);
            button22.Name = "button22";
            button22.Size = new Size(90, 91);
            button22.TabIndex = 4;
            toolTips.SetToolTip(button22, " Click to add the symbol of the player currently on their turn");
            button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button21.Location = new Point(6, 123);
            button21.Name = "button21";
            button21.Size = new Size(90, 91);
            button21.TabIndex = 3;
            toolTips.SetToolTip(button21, " Click to add the symbol of the player currently on their turn");
            button21.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(198, 27);
            button13.Name = "button13";
            button13.Size = new Size(90, 91);
            button13.TabIndex = 2;
            toolTips.SetToolTip(button13, " Click to add the symbol of the player currently on their turn");
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(102, 27);
            button12.Name = "button12";
            button12.Size = new Size(90, 91);
            button12.TabIndex = 1;
            toolTips.SetToolTip(button12, " Click to add the symbol of the player currently on their turn");
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(6, 27);
            button11.Name = "button11";
            button11.Size = new Size(90, 91);
            button11.TabIndex = 0;
            toolTips.SetToolTip(button11, " Click to add the symbol of the player currently on their turn");
            button11.UseVisualStyleBackColor = true;
            // 
            // gameStatsGroup
            // 
            gameStatsGroup.Controls.Add(winnerNameText);
            gameStatsGroup.Controls.Add(winnerLabel);
            gameStatsGroup.Controls.Add(resultsList);
            gameStatsGroup.Location = new Point(423, 128);
            gameStatsGroup.Name = "gameStatsGroup";
            gameStatsGroup.Size = new Size(274, 376);
            gameStatsGroup.TabIndex = 2;
            gameStatsGroup.TabStop = false;
            gameStatsGroup.Text = "Game Stats";
            // 
            // winnerNameText
            // 
            winnerNameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            winnerNameText.Location = new Point(88, 331);
            winnerNameText.Name = "winnerNameText";
            winnerNameText.ReadOnly = true;
            winnerNameText.Size = new Size(157, 27);
            winnerNameText.TabIndex = 2;
            toolTips.SetToolTip(winnerNameText, "Displays overall winner");
            // 
            // winnerLabel
            // 
            winnerLabel.AutoSize = true;
            winnerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            winnerLabel.Location = new Point(23, 333);
            winnerLabel.Name = "winnerLabel";
            winnerLabel.Size = new Size(65, 20);
            winnerLabel.TabIndex = 1;
            winnerLabel.Text = "Winner:";
            // 
            // resultsList
            // 
            resultsList.FormattingEnabled = true;
            resultsList.ItemHeight = 20;
            resultsList.Location = new Point(6, 27);
            resultsList.Name = "resultsList";
            resultsList.Size = new Size(260, 284);
            resultsList.TabIndex = 0;
            toolTips.SetToolTip(resultsList, "Game winner history");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = resetButton;
            ClientSize = new Size(709, 516);
            Controls.Add(gameStatsGroup);
            Controls.Add(gameAreaGroup);
            Controls.Add(gameSetupGroup);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            gameSetupGroup.ResumeLayout(false);
            gameSetupGroup.PerformLayout();
            gameAreaGroup.ResumeLayout(false);
            gameAreaGroup.PerformLayout();
            gameStatsGroup.ResumeLayout(false);
            gameStatsGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gameSetupGroup;
        private TextBox player2SymbolText;
        private TextBox player1SymbolText;
        private TextBox player2NameText;
        private TextBox player1NameText;
        private Label player2SymbolLabel;
        private Label player1SymbolLabel;
        private Label player2NameLabel;
        private Label player1NameLabel;
        private GroupBox gameAreaGroup;
        private Button button11;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button13;
        private Button button12;
        private Label nextTurnLabel;
        private Button resetButton;
        private Button continueButton;
        private Button startButton;
        private TextBox nextTurnNameText;
        private GroupBox gameStatsGroup;
        private ListBox resultsList;
        private TextBox winnerNameText;
        private Label winnerLabel;
        private ToolTip toolTips;
    }
}