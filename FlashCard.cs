using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardGame
{
    public partial class FlashCard : Form
    {
        // Lower and upper limits for generating random numbers
        // between 0 and 12 (exclusive)
        private const int lowerLimit = 1;
        private const int upperLimit = 11;

        // Maximum time (in secs) per game
        private const int MAX_TIME = 60;

        // Time left in current game
        private int timeLimit;

        // Math operation that is chosen for the current game
        private MathOperation currentGameOperation = MathOperation.InvalidOperation;

        // Math operation's string to display
        private Dictionary<MathOperation, string> mathOperationString;

        // Current question's operands
        private int operand1;
        private int operand2;

        // Hashset to track the operands
        private HashSet<(int, int)> uniqueOperands;

        // Points for the current game
        private int gamePoints;

        // Random number generator
        private Random random = new Random();

        public FlashCard()
        {
            InitializeComponent();

            // Setup the game time
            gameTimer.Tick += new EventHandler(TimerEventProcessor);
            gameTimer.Interval = 1000;

            // Generate the 'operation to string' map
            mathOperationString = new Dictionary<MathOperation, string>()
            {
                { MathOperation.Addition, "+" },
                { MathOperation.Subtraction, "-" },
                { MathOperation.Multiplication, "*" },
                { MathOperation.Division, "/" },
            };
        }

        // Initialize every individual games by setting up the necessary resources
        private void initializeGame()
        {
            // Set/Reset the time limit for the game
            timeLimit = MAX_TIME;

            // Initialize the unique operands
            uniqueOperands = new HashSet<(int, int)>();

            // Initialize game points
            gamePoints = 0;

            // Init the GUI items accordingly
            answerStatus.Text = "";
            gamePointsLabel.Text = $"{gamePoints.ToString()}";
            gameTimerLabel.Text = $"{MAX_TIME} secs left";
            gamePanel.Visible = true;
            homePanel.Visible = false;
            answerStatus.Visible = true;
            gameTimerLabel.Visible = true;

            // Generate a random question
            generateQuestion();

            // Start the game timer
            gameTimer.Start();
        }

        // Deinitialize by cleaning up the resources after each game
        private void deInitializeGame()
        {
            // Clean up resources
            uniqueOperands = null;

            gameTimer.Stop();
            currentGameOperation = MathOperation.InvalidOperation;

            gamePanel.Visible = false;
            homePanel.Visible = true;
            answerStatus.Text = "";
            gamePointsLabel.Text = "";
        }

        // The timer event that'll notify every second
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            // Decrement the timer
            timeLimit--;

            // Update the GUI label
            gameTimerLabel.Text = $"{timeLimit} secs left";

            // Close the game if timer expired
            if (timeLimit == 0)
            {
                gameTimer.Stop();
                gameTimerLabel.Visible = false;

                // Prompt the user that the game is over
                string msg = $"Time up. You scored {gamePoints} points";
                DialogResult res = MessageBox.Show(msg, "Game over!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (res == DialogResult.OK)
                {
                    deInitializeGame();
                }
            }
        }

        // The function that generates random numbers for operand1 & operand2
        // Note: In the unlikely event that all the numbers are exhausted,
        // we clear it up and start generating them again
        private void generateQuestion()
        {
            // Exit key when all the random numbers are exhausted
            int maxLoop = upperLimit * upperLimit;

            // Start game by generating random numbers for operand1 & operand2
            do
            {
                operand1 = random.Next(lowerLimit, upperLimit + 1);
                operand2 = random.Next(lowerLimit, upperLimit + 1);

                maxLoop--;

                // generate new ones if current one was previously used
            } while (uniqueOperands.Contains((operand1, operand2)) && (maxLoop !=0));

            // If all combos are exhausted, but user still has time,
            // then clear the existing generated numbers and re-use
            if (maxLoop == 0)
            {
                uniqueOperands = new HashSet<(int, int)>();

                operand1 = random.Next(lowerLimit, upperLimit + 1);
                operand2 = random.Next(lowerLimit, upperLimit + 1);
            }

            uniqueOperands.Add((operand1, operand2));

            operation.Text = $"{operand1.ToString()} {mathOperationString[currentGameOperation]} {operand2.ToString()} = ";
        }

        // Function to start a game
        private void startGame_Click(object sender, EventArgs e)
        {
            MathOperation currentOperation = MathOperation.InvalidOperation;
            string currentPlayer = userName.Text;

            // Get the current operation chosen by the user
            if (addition.Checked)
                currentOperation = MathOperation.Addition;
            else if (subtraction.Checked)
                currentOperation = MathOperation.Subtraction;
            else if (multiply.Checked)
                currentOperation = MathOperation.Multiplication;
            else if (division.Checked)
                currentOperation = MathOperation.Division;

            // Do basic validation
            if ((MathOperation.InvalidOperation == currentOperation) || string.IsNullOrWhiteSpace(currentPlayer))
            {
                _ = MessageBox.Show("Make sure you have valid input selection and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string msg = $"Hello {currentPlayer}, Welcome to the game.\nYou'll have one minute to play. Correct answers will fetch you 1 point and wrong answers will deduct one point";
                DialogResult res = MessageBox.Show(msg, "Let's play!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {
                    currentGameOperation = currentOperation;

                    // Initialize and begin the game
                    initializeGame();
                }
            }
        }

        // Function to submit a result for a single question
        // and generate the next question
        private void submit_Click(object sender, EventArgs e)
        {
            // Verify answer & update status/points
            int expectedAnswer;

            // Calculate the expected answer based on the operator
            switch (currentGameOperation)
            {
                case MathOperation.Addition:
                    expectedAnswer = operand1 + operand2;
                    break;

                case MathOperation.Subtraction:
                    expectedAnswer = operand1 - operand2;
                    break;

                case MathOperation.Multiplication:
                    expectedAnswer = operand1 * operand2;
                    break;

                case MathOperation.Division:
                    expectedAnswer = operand1 / operand2;
                    break;

                default:
                    // erroneous case
                    expectedAnswer = -1;
                    break;
            }

            // Verify the answer
            try
            {
                if (expectedAnswer == Int32.Parse(userInput.Text))
                {
                    answerStatus.Text = "Correct answer!";
                    answerStatus.ForeColor = Color.Green;
                    gamePoints++;
                }
                else
                {
                    answerStatus.Text = "Incorrect answer!";
                    answerStatus.ForeColor = Color.Red;
                    gamePoints--;
                }
            }
            catch (Exception exception)
            {
                answerStatus.Text = $"{exception.Message}. Try again!";
                answerStatus.ForeColor = Color.OrangeRed;
            }

            // Clear the input field
            userInput.Text = "";

            // Update the points
            gamePointsLabel.Text = $"{gamePoints.ToString()}";

            // Generate next question
            generateQuestion();

        }

        // Abort the game
        private void abortGame_Click(object sender, EventArgs e)
        {
            deInitializeGame();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
