using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{

    public partial class Form1 : Form
    {
        Button b1 = null;

        List<Button> buttonList = new List<Button>();
        Random random = new Random();
        int i = 0, j = 0;

        public Form1()
        {
            InitializeComponent();

           

                foreach (Button btn in panel1.Controls)
                {
                    buttonList.Add(btn);
                }



            foreach (Button btn in panel1.Controls)
            {
                btn.Text = "";
                btn.BackColor = Color.White;

            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onClick(object sender, EventArgs e)
        {
            Button clicked = sender as Button;


            if (b1 == null)
            {
                int counter = 1;
                b1 = clicked;
                b1.Enabled = false;
                b1.Text = "X";
                counter++;
               
                buttonList.Remove(b1);
                b1 = null;
                if (counter % 2 == 0 && (buttonList.Count != 0))
                {
                    int randomNumber = random.Next(buttonList.Count);
                    b1 = buttonList[randomNumber];
                    buttonList.Remove(b1);

                    b1.Text = "O";
                    b1.Enabled = false;
                    b1 = null;
                   
                }

                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") { 
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("You Win");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

                if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("You Lose, noob");
                    foreach (Button btn in panel1.Controls)
                    {
                        btn.Enabled = false;
                    }
                }

            }
        }
    }

}


        

    

       
    

