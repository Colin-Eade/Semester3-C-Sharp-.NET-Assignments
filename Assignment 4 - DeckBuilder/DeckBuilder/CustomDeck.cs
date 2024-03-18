/*
 * Filename:    CustomDeck.cs
 * Author:      Colin Eade
 * Date:        November 18, 2023
 * Description: Handles the CustomDeck class
 */

namespace DeckBuilder
{
    /// <summary>
    /// Represents a Custom Deck with 0 cards in it
    /// </summary>
    internal class CustomDeck : Deck
    {
        /// <summary>
        /// Initializes an instance of a custom deck
        /// </summary>
        public CustomDeck() : base()
        {
            // Inherits everything from the Deck class but starts with an empty deck
            Cards.Clear();
        }
    }
}
