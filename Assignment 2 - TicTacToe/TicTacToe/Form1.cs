/* Colin Eade
 * Last Modified: October 12, 2023
 * Tic-Tac-Toe
 * Simple Tic-Tac-Toe form app that can be played between 2 players
 */

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Max turns to determin a draw
        int MAX_TURNS = 9;

        // Strings for player1, player2 and currentTurn arrays
        string player1Name = "";
        string player2Name = "";
        string player1Symbol = "";
        string player2Symbol = "";

        // Counter for wins
        int player1Wins = 0;
        int player2Wins = 0;

        // Counter to check for a draw
        int turnCount = 0;

        // Game counter
        int gameCount = 0;

        // Player info
        string[] player1 = new string[2];
        string[] player2 = new string[2];

        // Current turn info
        string[] currentTurn = new string[2];

        // Button Array game board
        Button[,] buttonGameArray = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();

            // Initialize the game array
            InitializeButtonArray();

            // Disable buttons on startup
            DisableButtons();
        }

        /*
         * Puts each button in the proper order of a 3x3 array
         */
        private void InitializeButtonArray()
        {
            buttonGameArray[0, 0] = button11;
            buttonGameArray[0, 1] = button12;
            buttonGameArray[0, 2] = button13;
            buttonGameArray[1, 0] = button21;
            buttonGameArray[1, 1] = button22;
            buttonGameArray[1, 2] = button23;
            buttonGameArray[2, 0] = button31;
            buttonGameArray[2, 1] = button32;
            buttonGameArray[2, 2] = button33;

            // Makes the buttons in the array follow the proper game button logic within the GameButtonHandler function
            foreach (Button button in buttonGameArray)
            {
                button.Click += GameButtonHandler;
            }
        }
        /*
         * Disables buttons for when the form is first opened
         */
        private void DisableButtons()
        {
            // Disables all buttons in the array and remove any text that was on them
            foreach (Button button in buttonGameArray)
            {
                button.Enabled = false;
                button.Text = string.Empty;
            }
            // Disables the continue button
            continueButton.Enabled = false;
        }
        /*
         * Checks to see if all fields in the Game Setup area were filled out correctly and initilizes the game
         */
        private bool StartGameValidation()
        {
            // Grab the Game Startup text fields
            player1Name = player1NameText.Text;
            player2Name = player2NameText.Text;
            player1Symbol = player1SymbolText.Text;
            player2Symbol = player2SymbolText.Text;

            // Checks for empty fields
            if (player1Name == "" || player2Name == "" || player1Symbol == "" || player2Symbol == "")
            {
                MessageBox.Show("Please fill all game setup fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Checks and validates that each player symbol is different
            else if (player1Name == player2Name || player1Symbol == player2Symbol)
            {
                MessageBox.Show("Each player must have a different name and symbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validates that a symbol is only 1 character
            else if (player1Symbol.Length > 1 || player2Symbol.Length > 1)
            {
                MessageBox.Show("Symbols can only be a single character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // enable all buttons in the game array
                foreach (Button button in buttonGameArray)
                {
                    button.Enabled = true;
                }
                // Disable game setup fields
                player1NameText.Enabled = false;
                player2NameText.Enabled = false;
                player1SymbolText.Enabled = false;
                player2SymbolText.Enabled = false;

                // Disable Start button
                startButton.Enabled = false;

                // initialize players
                player1[0] = player1Symbol;
                player1[1] = player1Name;

                player2[0] = player2Symbol;
                player2[1] = player2Name;

                // Set the current turn
                currentTurn = player1;
                nextTurnNameText.Text = player2[1];

                return true;
            }
        }
        /*
         * Enables a game to be played upon validating the game setup fields
         */
        private void startButton_Click(object sender, EventArgs e)
        {
            StartGameValidation();
        }
        /*
         * Will switch to the next players turn upon clicking a button in the game array
         */
        private void NextTurn()
        {
            // if the turn is on player1
            if (currentTurn == player1)
            {
                // The turn will switch to player 2
                currentTurn = player2;
                nextTurnNameText.Text = player1[1];
            }
            // If the turn is on player2
            else
            {
                // The turn will switch to player1
                currentTurn = player1;
                nextTurnNameText.Text = player2[1];
            }
        }
        private void GameButtonHandler(object sender, EventArgs e)
        {
            // Enables logic to be applied to the game array button that is clicked
            var clickedButton = sender as Button;

            if (clickedButton != null)
            {

                // Set button text to current player's symbol
                clickedButton.Text = currentTurn[0];

                // Disables the button
                clickedButton.Enabled = false;

                // Add 1 to the turn count
                turnCount++;

                // Check for a win or a draw
                if (CheckWin() || CheckDraw())
                {
                    // If there is a win or draw perform the EndGame() function
                    EndGame();
                }
                // The game is not over
                else
                {
                    // Switches to the next player's turn
                    NextTurn();
                }
            }
        }
        /*
         * Checks for a win
         * Compares the player symbols on the gameButtonArray to if statement win conditons
         * Will compare the symbol (buttonGameArray[row, x].Text) to the to the player that just took their last turn (currentTurn[0])
         */
        private bool CheckWin()
        {
            // Checking rows
            for (int row = 0; row < 3; row++)
            {
                if (buttonGameArray[row, 0].Text == currentTurn[0] &&      // checks (0,0) , (1,0) , (2,0) 
                    buttonGameArray[row, 1].Text == currentTurn[0] &&      // checks (0,1) , (1,1) , (2,1) 
                    buttonGameArray[row, 2].Text == currentTurn[0])        // checks (0,2) , (1,2) , (2,2) 
                {
                    // Will only return true if currentTurn (The current player's symbol) is found across a row
                    return true;
                }
            }
            // Checking columns
            for (int col = 0; col < 3; col++)
            {
                if (buttonGameArray[0, col].Text == currentTurn[0] &&      // checks (0,0) , (0,1) , (0,2) 
                    buttonGameArray[1, col].Text == currentTurn[0] &&      // checks (1,0) , (1,1) , (1,2) 
                    buttonGameArray[2, col].Text == currentTurn[0])        // checks (2,0) , (2,1) , (2,2) 
                {
                    // Will only return true if currentTurn (The current player's symbol) is found down a column
                    return true;
                }
            }

            // Check downward left to right diagonal
            if (buttonGameArray[0, 0].Text == currentTurn[0] &&
                buttonGameArray[1, 1].Text == currentTurn[0] &&
                buttonGameArray[2, 2].Text == currentTurn[0])
            {
                return true;
            }
            // Check upward left to right diagonal
            if (buttonGameArray[0, 2].Text == currentTurn[0] &&
                buttonGameArray[1, 1].Text == currentTurn[0] &&
                buttonGameArray[2, 0].Text == currentTurn[0])
            {
                return true;
            }

            // No winner
            return false;
        }
        /*
         * Checks for a draw
         */
        private bool CheckDraw()
        {
            // If the turn count reaches 9 (all buttons clicked) and a win condition hasnt been met then its a draw
            if (turnCount == MAX_TURNS)
            {
                // Return true if there is a draw
                return true;
            }
            // Not a draw
            else
            {
                // Return false
                return false;
            }
        }
        /*
         * Performs end game logic upon a win or draw
         * Adds 1 to the game count and enables the continue button
         * Updates the results list with the game number and winner/draw of the game
         * Updates the overall winner text to display the player with the most wins or display if its a tie
         */
        private void EndGame()
        {
            // Add 1 to the game counter
            gameCount++;

            // Enable the continue button
            continueButton.Enabled = true;

            // If a game was won
            if (CheckWin())
            {
                // Inform the user and add the winner to the game stats
                MessageBox.Show($"{currentTurn[1]} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultsList.Items.Add($"Game {gameCount}: {currentTurn[1]}");

                // Add a win to the winning player's total
                if (currentTurn == player1)
                {
                    player1Wins++;
                }
                else if (currentTurn == player2)
                {
                    player2Wins++;
                }
            }
            // If it was a tie
            else if (CheckDraw())
            {
                // Inform the user and update the game stats
                MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultsList.Items.Add($"Game {gameCount}: Draw");
            }

            // Update the overall winner text
            if (player1Wins > player2Wins)
            {
                winnerNameText.Text = player1[1];
            }
            else if (player2Wins > player1Wins)
            {
                winnerNameText.Text = player2[1];
            }
            else
            {
                winnerNameText.Text = "Tied";
            }
        }
        /*
         * Performs the logic for the continue button
         * Re-enables all buttons in the game array and resets the text in them
         * Resets the turn to player1 and puts the turn count back to 0
         */
        private void ContinueLogic()
        {
            // Enables all buttons in the array
            foreach (Button button in buttonGameArray)
            {
                button.Enabled = true;
                button.Text = string.Empty;
            }
            // reset relevant counters and fields
            turnCount = 0;

            // Switches the starting player of each game for fairness
            if (currentTurn == player1)
            {
                currentTurn = player2;
                nextTurnNameText.Text = player1[1];
            }
            else
            {
                currentTurn = player1;
                nextTurnNameText.Text = player2[1];
            }
        }
        /*
         * Performs the ContinueLogic() function when the Continue button is clicked
         */
        private void continueButton_Click(object sender, EventArgs e)
        {
            ContinueLogic();
        }
        /*
         * Resets the form to the initial state that it was opened in
         */
        private void ResetForm()
        {
            // Reset variables
            player1Name = string.Empty;
            player2Name = string.Empty;
            player1Symbol = string.Empty;
            player2Symbol = string.Empty;
            player1Wins = 0;
            player2Wins = 0;
            turnCount = 0;
            gameCount = 0;

            // Reset arrays
            player1 = new string[2];
            player2 = new string[2];
            currentTurn = new string[2];

            // Clear and enable game setup fields
            player1NameText.Clear();
            player1NameText.Enabled = true;
            player2NameText.Clear();
            player2NameText.Enabled = true;
            player1SymbolText.Clear();
            player1SymbolText.Enabled = true;
            player2SymbolText.Clear();
            player2SymbolText.Enabled = true;

            // Clear and disable game array and continue button
            DisableButtons();

            // Enable start button
            startButton.Enabled = true;

            // Clear Next turn field
            nextTurnNameText.Clear();

            // Clear Game Stats Fields
            resultsList.Items.Clear();
            winnerNameText.Clear();
        }
        /*
         * Runs the resetForm function when the Reset button is clicked
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}