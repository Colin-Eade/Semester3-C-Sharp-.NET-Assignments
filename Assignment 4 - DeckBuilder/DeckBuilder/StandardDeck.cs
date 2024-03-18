/*
 * Filename:    StandardDeck.cs
 * Author:      Colin Eade
 * Date:        November 18, 2023
 * Description: Handles the StandardDeck class
 */

namespace DeckBuilder
{
    /// <summary>
    /// Represents a Standard Deck of 52 Cards
    /// </summary>
    internal class StandardDeck : Deck
    {
        /// <summary>
        /// Initializes an instance of a standard deck
        /// </summary>
        public StandardDeck() : base()
        {
            // Inherits everything from the Deck class and also creates a deck of 52 cards
        }
    }
}
