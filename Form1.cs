using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        int turn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string convertTurnToChar(int turn)
        {
            int remainder = turn % 2;
            if (remainder == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        private string checkForWin()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X"))
            {
                return "X";
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O"))
            {
                return "O";
            }
            else
            {
                return " ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button1.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button1.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button2.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button2.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";

                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button3.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button3.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button4.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button4.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button5.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button5.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button6.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button6.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button7.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button7.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button8.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button8.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string winner = checkForWin();
            if (button9.Text == " " && winner == " ")
            {
                string turnChar = convertTurnToChar(turn);
                button9.Text = turnChar;
                turn++;
                turnChar = convertTurnToChar(turn);
                label2.Text = turnChar + "'s turn";
                winner = checkForWin();
                if (winner != " ")
                {
                    label2.Text = winner + " wins!";
                }
            }
        }

    }
}
