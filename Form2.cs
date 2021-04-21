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
    public partial class Form2 : Form
    {
        public string winner;
        private Form1 board;
        public Form2(Form1 b)
        {
            board = b;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void showWinner(object sender, EventArgs e)
        {
            winnerLabel.Text = "Wygrywa: " + winner; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.clearBoard();
            this.Close();
        }
    }
}
