/*
 * Filename:    Card.cs
 * Author:      Colin Eade
 * Date:        November 18, 2023
 * Description: Handles the Card class
 */

namespace DeckBuilder
{
    /// <summary>
    /// Represents a playing card
    /// </summary>
    internal class Card
    {
        // Valid property arrays
        public static readonly string[] validSuits = { "Hearts", "Clubs", "Diamonds", "Spades" };
        public static readonly string[] validRanks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", 
                                                       "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        // Properties
        public string Suit { get; private set; }
        public string Rank { get; private set; }

        /// <summary>
        /// Validates rank and suit
        /// Initializes a new instance of the card class
        /// </summary>
        /// <param name="suit">The card's suit</param>
        /// <param name="rank">The card's rank</param>
        public Card(string suit, string rank)
        {
            // Validate Suit and Rank
            ValidateSuitandRank(suit, rank);

            Suit = suit;
            Rank = rank;
        }

        /// <summary>
        /// Validates a card's siot and rank
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">An exception if the suit or rank is invalid</exception>
        private bool ValidateSuitandRank(string suit, string rank)
        {
            // Raise an exception for an invalid suit
            if (Array.IndexOf(validSuits, suit) < 0)
            {
                throw new ArgumentException("Invalid suit." +
                "\n\nValid suits are: Hearts, Clubs, Diamonds, and Spades.");
            }
            // Raise an exception for an invalid rank
            else if (Array.IndexOf(validRanks, rank) < 0)
            {
                throw new ArgumentException("Invalid rank." +
                "\n\nValid ranks are: Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, " +
                "Queen, and King");
            }

            // Valid suit and rank
            return true;
        }

        /// <summary>
        /// Creates a string of a card's suit and rank
        /// </summary>
        /// <returns>A string of the card's suit and rank</returns>
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

}
