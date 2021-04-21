using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        enum CurrentPlayer {
            Cross,
            Circle
        }
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabe();
        }

        private void tr_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            checkForWinner();
            changeLabe();
        }
        public void changeLabe()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzyżyk";
            }
            else
            {
                currentPlayerLabel.Text = "Kółko";
            }
        }
        public void checkForWinner()
        {
            if(String.Compare(tl.Text, cl.Text) == 0 && String.Compare(cl.Text, bl.Text) == 0)
            {
                Form2 victoryscreen = new Form2(this);
                victoryscreen.winner = tl.Text;
                victoryscreen.Show();
            }
        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
            currentPlayer = CurrentPlayer.Cross; 
        }
    }
}
