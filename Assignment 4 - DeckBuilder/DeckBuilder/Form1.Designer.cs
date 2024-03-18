namespace DeckBuilder
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
            cardLabel = new Label();
            rankLabel = new Label();
            suitLabel = new Label();
            suitInput = new TextBox();
            rankInput = new TextBox();
            addCustomButton = new Button();
            drawLabel = new Label();
            drawInput = new TextBox();
            dealButton = new Button();
            cardsDealtLabel = new Label();
            cardsDealtList = new ListBox();
            deckLabel = new Label();
            deckList = new ListBox();
            viewDeckButton = new Button();
            exitButton = new Button();
            resetButton = new Button();
            shuffleButton = new Button();
            toolTips = new ToolTip(components);
            deleteCardButton = new Button();
            foldHandButton = new Button();
            SuspendLayout();
            // 
            // cardLabel
            // 
            cardLabel.AutoSize = true;
            cardLabel.Location = new Point(12, 10);
            cardLabel.Margin = new Padding(4);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new Size(32, 15);
            cardLabel.TabIndex = 0;
            cardLabel.Text = "Card";
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Location = new Point(12, 56);
            rankLabel.Margin = new Padding(4);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new Size(33, 15);
            rankLabel.TabIndex = 3;
            rankLabel.Text = "Rank";
            // 
            // suitLabel
            // 
            suitLabel.AutoSize = true;
            suitLabel.Location = new Point(12, 33);
            suitLabel.Margin = new Padding(4);
            suitLabel.Name = "suitLabel";
            suitLabel.Size = new Size(27, 15);
            suitLabel.TabIndex = 1;
            suitLabel.Text = "Suit";
            // 
            // suitInput
            // 
            suitInput.Location = new Point(55, 31);
            suitInput.Margin = new Padding(0, 0, 4, 0);
            suitInput.Name = "suitInput";
            suitInput.Size = new Size(110, 23);
            suitInput.TabIndex = 2;
            toolTips.SetToolTip(suitInput, "The suit of the card you would like to create.");
            // 
            // rankInput
            // 
            rankInput.Location = new Point(55, 53);
            rankInput.Margin = new Padding(0, 0, 4, 0);
            rankInput.Name = "rankInput";
            rankInput.Size = new Size(110, 23);
            rankInput.TabIndex = 4;
            toolTips.SetToolTip(rankInput, "The rank of the card you would like to create.");
            // 
            // addCustomButton
            // 
            addCustomButton.Location = new Point(174, 33);
            addCustomButton.Margin = new Padding(4);
            addCustomButton.Name = "addCustomButton";
            addCustomButton.Size = new Size(88, 43);
            addCustomButton.TabIndex = 5;
            addCustomButton.Text = "&Add Custom";
            toolTips.SetToolTip(addCustomButton, "Clicking this adds a custom card to the deck after a valid suit and rank have been entered.");
            addCustomButton.UseVisualStyleBackColor = true;
            addCustomButton.Click += addCustomButton_Click;
            // 
            // drawLabel
            // 
            drawLabel.AutoSize = true;
            drawLabel.Location = new Point(12, 93);
            drawLabel.Margin = new Padding(4, 19, 4, 4);
            drawLabel.Name = "drawLabel";
            drawLabel.Size = new Size(34, 15);
            drawLabel.TabIndex = 6;
            drawLabel.Text = "Draw";
            // 
            // drawInput
            // 
            drawInput.Location = new Point(55, 91);
            drawInput.Margin = new Padding(0, 0, 4, 0);
            drawInput.Name = "drawInput";
            drawInput.Size = new Size(110, 23);
            drawInput.TabIndex = 7;
            toolTips.SetToolTip(drawInput, "The amount of cards you would like to draw from the deck.");
            // 
            // dealButton
            // 
            dealButton.Location = new Point(173, 93);
            dealButton.Margin = new Padding(4);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(88, 22);
            dealButton.TabIndex = 8;
            dealButton.Text = "&Deal";
            toolTips.SetToolTip(dealButton, "Clicking this deals cards from the deck to you after a valid amount has been entered.");
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButton_Click;
            // 
            // cardsDealtLabel
            // 
            cardsDealtLabel.AutoSize = true;
            cardsDealtLabel.Location = new Point(55, 130);
            cardsDealtLabel.Margin = new Padding(4, 19, 4, 4);
            cardsDealtLabel.Name = "cardsDealtLabel";
            cardsDealtLabel.Size = new Size(67, 15);
            cardsDealtLabel.TabIndex = 9;
            cardsDealtLabel.Text = "Cards Dealt";
            // 
            // cardsDealtList
            // 
            cardsDealtList.FormattingEnabled = true;
            cardsDealtList.ItemHeight = 15;
            cardsDealtList.Location = new Point(55, 148);
            cardsDealtList.Margin = new Padding(4, 0, 4, 4);
            cardsDealtList.Name = "cardsDealtList";
            cardsDealtList.Size = new Size(207, 169);
            cardsDealtList.TabIndex = 10;
            toolTips.SetToolTip(cardsDealtList, "Displays the cards that have been dealt to you from the deck.");
            // 
            // deckLabel
            // 
            deckLabel.AutoSize = true;
            deckLabel.Location = new Point(288, 10);
            deckLabel.Margin = new Padding(4, 19, 4, 4);
            deckLabel.Name = "deckLabel";
            deckLabel.Size = new Size(33, 15);
            deckLabel.TabIndex = 11;
            deckLabel.Text = "Deck";
            // 
            // deckList
            // 
            deckList.FormattingEnabled = true;
            deckList.ItemHeight = 15;
            deckList.Location = new Point(288, 28);
            deckList.Margin = new Padding(22, 0, 4, 4);
            deckList.Name = "deckList";
            deckList.Size = new Size(207, 289);
            deckList.TabIndex = 12;
            toolTips.SetToolTip(deckList, "Displays the cards in the deck.");
            // 
            // viewDeckButton
            // 
            viewDeckButton.Location = new Point(522, 26);
            viewDeckButton.Margin = new Padding(22, 4, 4, 4);
            viewDeckButton.Name = "viewDeckButton";
            viewDeckButton.Size = new Size(88, 22);
            viewDeckButton.TabIndex = 13;
            viewDeckButton.Text = "&View Deck";
            toolTips.SetToolTip(viewDeckButton, "Clicking this toggles whether you can see the cards in the deck.");
            viewDeckButton.UseVisualStyleBackColor = true;
            viewDeckButton.Click += viewDeckButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(522, 325);
            exitButton.Margin = new Padding(22, 4, 4, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(88, 22);
            exitButton.TabIndex = 16;
            exitButton.Text = "E&xit";
            toolTips.SetToolTip(exitButton, "Clicking this exits the application.");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(522, 116);
            resetButton.Margin = new Padding(22, 4, 4, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(88, 22);
            resetButton.TabIndex = 15;
            resetButton.Text = "&Reset";
            toolTips.SetToolTip(resetButton, "Clicking this resets the application to it's initial state.");
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // shuffleButton
            // 
            shuffleButton.Location = new Point(522, 56);
            shuffleButton.Margin = new Padding(22, 4, 4, 4);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(88, 22);
            shuffleButton.TabIndex = 14;
            shuffleButton.Text = "&Shuffle";
            toolTips.SetToolTip(shuffleButton, "Clicking this shuffles the cards in the deck to a random order.");
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // deleteCardButton
            // 
            deleteCardButton.Location = new Point(522, 86);
            deleteCardButton.Margin = new Padding(22, 4, 4, 4);
            deleteCardButton.Name = "deleteCardButton";
            deleteCardButton.Size = new Size(88, 22);
            deleteCardButton.TabIndex = 17;
            deleteCardButton.Text = "Delete &Card";
            toolTips.SetToolTip(deleteCardButton, "Clicking this deletes a selected card from the deck.");
            deleteCardButton.UseVisualStyleBackColor = true;
            deleteCardButton.Click += deleteCardButton_Click;
            // 
            // foldHandButton
            // 
            foldHandButton.Location = new Point(55, 325);
            foldHandButton.Margin = new Padding(22, 4, 4, 4);
            foldHandButton.Name = "foldHandButton";
            foldHandButton.Size = new Size(88, 22);
            foldHandButton.TabIndex = 18;
            foldHandButton.Text = "&Fold Hand";
            toolTips.SetToolTip(foldHandButton, "Clicking this folds the cards that were dealt to you and puts them back into the deck.");
            foldHandButton.UseVisualStyleBackColor = true;
            foldHandButton.Click += foldHandButton_Click;
            // 
            // Form1
            // 
            AcceptButton = addCustomButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = resetButton;
            ClientSize = new Size(623, 358);
            Controls.Add(foldHandButton);
            Controls.Add(deleteCardButton);
            Controls.Add(shuffleButton);
            Controls.Add(resetButton);
            Controls.Add(exitButton);
            Controls.Add(viewDeckButton);
            Controls.Add(deckList);
            Controls.Add(deckLabel);
            Controls.Add(cardsDealtList);
            Controls.Add(cardsDealtLabel);
            Controls.Add(dealButton);
            Controls.Add(drawInput);
            Controls.Add(drawLabel);
            Controls.Add(addCustomButton);
            Controls.Add(rankInput);
            Controls.Add(suitInput);
            Controls.Add(suitLabel);
            Controls.Add(rankLabel);
            Controls.Add(cardLabel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deck Builder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cardLabel;
        private Label rankLabel;
        private Label suitLabel;
        private TextBox suitInput;
        private TextBox rankInput;
        private Button addCustomButton;
        private Label drawLabel;
        private TextBox drawInput;
        private Button dealButton;
        private Label cardsDealtLabel;
        private ListBox cardsDealtList;
        private Label deckLabel;
        private ListBox deckList;
        private Button viewDeckButton;
        private Button exitButton;
        private Button resetButton;
        private Button shuffleButton;
        private ToolTip toolTips;
        private Button deleteCardButton;
        private Button foldHandButton;
    }
}