using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private GameFactory gameFactory;
        private Game game;

        public Form1()
        {
            InitializeComponent();
            gameFactory = new GameFactory();
            game = gameFactory.CreateGame();
        }

        private string GetUserChoice()
        {
            if (radio_Rock.Checked)
            {
                return "rock";
            }
            else if (radio_Paper.Checked)
            {
                return "paper";
            }
            else if (radio_Scissors.Checked)
            {
                return "scissors";
            }
            else
            {
                MessageBox.Show("Select a choice.");
                return "";
            }
        }

        private void buttonPlay_Click_1(object sender, EventArgs e)
        {
            string userChoice = GetUserChoice();
            string computerChoice = game.GetComputerChoice();
            labelComputerChoice.Text = $"Computer's choice: {computerChoice}";
            game.DetermineWinner(userChoice, computerChoice);
            labelScore.Text = $"Score: User - {game.UserScore}, Computer - {game.ComputerScore}";
            if (game.RoundsPlayed == 3)
            {
                buttonPlay.Enabled = false;
            }
        }
    }

    public class GameFactory
    {
        public Game CreateGame()
        {
            return new Game();
        }
    }

    public class Game
    {
        private int userScore;
        private int computerScore;
        private int roundsPlayed;

        public Game()
        {
            userScore = 0;
            computerScore = 0;
            roundsPlayed = 0;
        }

        public int UserScore
        {
            get { return userScore; }
        }

        public int ComputerScore
        {
            get { return computerScore; }
        }

        public int RoundsPlayed
        {
            get { return roundsPlayed; }
        }

        public string GetComputerChoice()
        {
            Random random = new Random();
            int choice = random.Next(3);
            switch (choice)
            {
                case 0:
                    return "rock";
                case 1:
                    return "paper";
                default:
                    return "scissors";
            }
        }

        public void DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                MessageBox.Show("Tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "scissors" && computerChoice == "paper") ||
                     (userChoice == "paper" && computerChoice == "rock"))
            {
                MessageBox.Show("U win!");
                userScore++;
            }
            else
            {
                MessageBox.Show("U lose!");
                computerScore++;
            }
            roundsPlayed++;
        }
    }
}
