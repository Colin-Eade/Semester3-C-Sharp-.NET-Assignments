/*
 * Filename:    Deck.cs
 * Author:      Colin Eade
 * Date:        November 18, 2023
 * Description: Handles the Deck class
 */

namespace DeckBuilder
{
    /// <summary>
    /// Represents a deck of cards and the actions you can perform on them
    /// </summary>
    internal abstract class Deck
    {
        // Cards list
        public List<Card> Cards { get; protected set; }

        /// <summary>
        /// Initializes an instance of the deck class
        /// </summary>
        protected Deck()
        {
            Cards = new List<Card>();
            CreateDeck();
        }

        /// <summary>
        /// Creates a standard 52 card deck
        /// </summary>
        protected void CreateDeck()
        {
            // For each card suit
            foreach (string suit in Card.validSuits)
            {
                // For each card rank
                foreach (string rank in Card.validRanks)
                {
                    // Create a card for each Suit/Rank combo
                    Cards.Add(new Card(suit, rank));
                }
            }
        }

        /// <summary>
        /// Shuffles a card deck to a random order
        /// </summary>
        public void ShuffleDeck()
        {
            // Random object to make random int
            Random random = new Random();

            // Count of the deck starting at max count
            int count = Cards.Count;


            while (count > 0)
            {   
                // Randomly generate index places for the cards
                int index = random.Next(count);
                count--;

                Card card = Cards[index];
                Cards[index] = Cards[count];
                Cards[count] = card;
            }
        }

        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="suit">The suit of the card</param>
        /// <param name="rank">The rank of the card</param>
        public void AddCard(string suit, string rank)
        {
            // Create new card
            Card card = new Card(suit, rank);

            // Add card to beginning of deck list
            // Mimicks first in last out of a deck
            Cards.Insert(0, card);
        }

        /// <summary>
        /// Draws cards from the deck into a new list
        /// </summary>
        /// <param name="amount">The amount of cards to be drawn from the deck</param>
        /// <returns>A list of cards taken from the deck</returns>
        public List<Card> DrawCard(int amount)
        {
            // Validate the amount
            ValidateDrawAmount(amount);

            // Add cards within the amount rande to the drawnCards list
            List<Card> drawnCards = Cards.GetRange(0, amount);

            // Remove the cards within the amount range from the deck list
            Cards.RemoveRange(0, amount);

            // Reverse list to mimick first in last out of a draw
            drawnCards.Reverse();

            // Return the drawnCards list
            return drawnCards;
        }

        /// <summary>
        /// Validates the draw amount integer
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">An exception if the amount is <= 0</exception>
        /// <exception cref="InvalidOperationException">An exception if the amount exceeds the amount of cards
        /// in the deck</exception>
        protected bool ValidateDrawAmount(int amount)
        {
            // Throw an exception if the amount is <= 0
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than 0.");
            }
            // Throw and exception if the amount is greater than the amount of cards in the deck
            else if (amount > Cards.Count)
            {
                throw new InvalidOperationException("Not enough cards in the deck.");
            }

            // Valid amount
            return true;
        }

        /// <summary>
        /// Removes a card from the deck
        /// </summary>
        /// <param name="index">The index of the card in the deck</param>
        public void DeleteCard(int index)
        {
            Cards.RemoveAt(index);
        }
    }
}
