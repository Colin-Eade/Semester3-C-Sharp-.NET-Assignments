/*
 * Filename:    Form1.cs
 * Author:      Colin Eade
 * Date:        November 18, 2023
 * Description: A form application that allows a user to create, deal, fold, add to, and remove from a deck
 *              of cards
 */

namespace DeckBuilder
{
    public partial class Form1 : Form
    {
        // Deck class
        Deck userDeck;

        // List for cards dealt to the user
        List<Card> userHand;

        public Form1()
        {
            InitializeComponent();

            // Choose standard or custom deck
            ChooseDeckType();

            // Initialize an empty user hand
            userHand = new List<Card>();
        }

        /// <summary>
        /// Prompts the user to start with a standard deck or custom deck
        /// Standard decks start with a standard 52 playing cards
        /// Custom decks start empty
        /// </summary>
        private void ChooseDeckType()
        {
            string message = "Would you like to start with a standard deck of 52 cards?" +
                             "\n\nSelect 'Yes' for a standard deck with the typical 52 cards." +
                             "\n\nSelect 'No' to create your own custom deck from scratch.";
            string title = "Choose Deck Type";

            // Yes/No message
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            // Start with a standard deck if user selects yes
            if (result == DialogResult.Yes)
            {
                userDeck = new StandardDeck();
            }
            // Start with a custom deck if user selects no
            else
            {
                userDeck = new CustomDeck();
            }
        }

        /// <summary>
        /// Refresh the Deck ListView
        /// </summary>
        private void RefreshDeckList()
        {
            deckList.Items.Clear();
            foreach (Card card in userDeck.Cards)
            {
                deckList.Items.Add(card.ToString());
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Resets the form to its initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Performs the reset form logic
        /// </summary>
        private void ResetForm()
        {
            // Clear all fields
            suitInput.Clear();
            rankInput.Clear();
            drawInput.Clear();
            cardsDealtList.Items.Clear();
            deckList.Items.Clear();

            // Prompt the user to choose a deck type
            ChooseDeckType();

            // Initialize an empty user hand
            userHand = new List<Card>();
        }

        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomButton_Click(object sender, EventArgs e)
        {
            // Variables
            string suit = suitInput.Text;
            string rank = rankInput.Text;

            // Add a card to the deck and clear the input fields
            try
            {
                userDeck.AddCard(suit, rank);
                suitInput.Clear();
                suitInput.Focus();
                rankInput.Clear();
            }
            // Raise an exception for invalid inputs and focus the invalid field
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (ex.Message.StartsWith("Invalid suit"))
                {
                    suitInput.Clear();
                    suitInput.Focus();
                }
                else if (ex.Message.StartsWith("Invalid rank"))
                {
                    rankInput.Clear();
                    rankInput.Focus();
                }
            }

            // If the deck view is toggled on refresh the deck list
            if (deckList.Items.Count > 0)
            {
                RefreshDeckList();
            }
        }

        /// <summary>
        /// Toggles whether the user can view the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewDeckButton_Click(object sender, EventArgs e)
        {
            // Inform the user if there are no cards in the deck to view
            if (userDeck.Cards.Count == 0)
            {
                string message = "No cards in deck to view.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Toggle view OFF
            // Clear the deck list if there are items in it
            if (deckList.Items.Count > 0)
            {
                deckList.Items.Clear();
            }
            // Toggle view ON
            // Refresh the deck list to view the cards
            else
            {
                RefreshDeckList();
            }
        }

        /// <summary>
        /// Shuffles the deck of cards to a random order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shuffleButton_Click(object sender, EventArgs e)
        {
            // Inform the user if there are no cards to shuffle
            if (userDeck.Cards.Count == 0)
            {
                string message = "No cards in deck to shuffle.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Shuffle the deck
            userDeck.ShuffleDeck();

            // If the deck view is toggled on refresh the deck list to show the shuffle
            if (deckList.Items.Count > 0)
            {
                RefreshDeckList();
            }
        }

        /// <summary>
        /// Deals cards from the top of the deck to the user hand
        /// Mimicks first in last out of a deck where the user's newer cards are at the top of their hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealButton_Click(object sender, EventArgs e)
        {
            // User input variable
            string userInput = drawInput.Text;

            // Raise an exception if the user input isn't an integer and focus the field
            if (!int.TryParse(userInput, out int amount))
            {
                string message = "Please enter a valid number.";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                drawInput.Clear();
                drawInput.Focus();
                return;
            }

            try
            {
                // Draw cards in a temptory new card list
                List<Card> newDrawnCards = userDeck.DrawCard(amount);

                // Add them to the top of the user hand
                userHand.InsertRange(0, newDrawnCards);

                // Clear and focus the input
                drawInput.Clear();
                drawInput.Focus();
            }
            // Raise an exception if the amount is not valid
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                drawInput.Clear();
                drawInput.Focus();
            }

            // If the deck list view is toggled on
            if (deckList.Items.Count > 0)
            {
                // Refresh the decklist to remove the cards drawn from it
                RefreshDeckList();
            }

            // Refresh the cardsDealtList to show the new cards at the top of the user hand
            cardsDealtList.Items.Clear();
            foreach (Card card in userHand)
            {
                cardsDealtList.Items.Add(card.ToString());
            }
        }

        /// <summary>
        /// Removes the cards from the user hand and returns back to the top of the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void foldHandButton_Click(object sender, EventArgs e)
        {
            // If the user has no cards in their hand
            if (userHand.Count == 0)
            {
                string message = "No cards in hand to fold.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add cards in userHand back to the userDeck
            foreach (Card card in userHand)
            {
                // Variables
                string suit = card.Suit;
                string rank = card.Rank;

                userDeck.AddCard(suit, rank);
            }

            // Reset the user hand back to an empty list
            userHand = new List<Card>();

            // If the deck view is toggled on refresh the list to show the cards added back
            if (deckList.Items.Count > 0)
            {
                RefreshDeckList();
            }

            // Clear the cards dealt list
            cardsDealtList.Items.Clear();
        }

        /// <summary>
        /// Deletes a selected card from the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteCardButton_Click(object sender, EventArgs e)
        {
            // Inform the user if no card is selected
            if (deckList.SelectedItem == null)
            {
                string message = "No card selected to delete.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Grab the index of the selected card
            int index = deckList.SelectedIndex;

            // Delete the selected card from the deck
            userDeck.DeleteCard(index);

            // If the deck view is toggled on refresh the deck list
            if (deckList.Items.Count > 0)
            {
                RefreshDeckList();
            }
        }
    }
}