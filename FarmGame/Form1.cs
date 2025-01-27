using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, b, c, move,wins,balance,loss;

        private void btn_bid_Click(object sender, EventArgs e)
        {
            lbl_casiino.Text = "Farm Game";
            balance = 0;
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Focus();
            btn_play.Enabled = true;
            btn_play.Text = "Joaca!";
            lbl_balance.Text = "Balanta:";
        }

        void Game_Result()
        {
            if (a != 0 && b != 0 && c != 0)
            {
                if (Convert.ToInt32(a % b) != c)
                {
                    wins++;
                    lbl_win.Text = "Castiguri :" + wins;
                    balance += 2;
                    lbl_balance.Text = "Balanta : " + Convert.ToInt32(textBox1.Text) * balance;
                    btn_play.Text = "Continua sa joci...";
                    lbl_casiino.Text = "Ai castigat!";
                }
                
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ajuta animalutele sa isi gaseasca familiile folosindu-ti monedele norocoase! In cazul in care ii vei ajuta sa se regaseasca , suma ta de monede norocoase se va dubla. Atentie! Unele monede norocoase se vor dubla si daca gasiti 2 dintre animalute");
            }
            else
            {
                timer1.Enabled = true;
                lbl_casiino.Text = "Farm Game";
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Black;
            }
        }
        private void lbl_casiino_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                a = rnd.Next(5);
                b = rnd.Next(5);
                c = rnd.Next(5);
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.oaie;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.tap;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.vaca;
                        break;
                }
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.oaie;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.tap;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.vaca;
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.oaie;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.tap;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.vaca;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
                Game_Result();
            }
        }
    }
}
