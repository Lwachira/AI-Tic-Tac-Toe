using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lincoln_Khodani_Tic_Tac_Toe
{
    /// <summary>
    /// This code was inspired by group from last year
    /// </summary>
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        string[,] game = new string[3, 3] { { "W", "W", "W" }, { "W", "W", "W" }, { "W", "W", "W" } };
        int moves = 0;
        string winner = "";
        int first = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            MaterialRaisedButton btTest = (MaterialRaisedButton)sender;
            bool theWinner = false;
            first++;

            //HUMAN MOVES
            string[] conners = { "a1", "a3", "c1", "c3" };

            if (btTest.Name == "A1")
            {
                btTest.Text = "X";
                game[0, 0] = btTest.Text;
                moves++;
            }
             if (btTest.Name == "A2")
            {
                btTest.Text = "X";
                game[0, 1] = btTest.Text;
                moves++;
            }
             if (btTest.Name == "A3")
            {
                btTest.Text = "X";
                game[0, 2] = btTest.Text;
            }
            //////////////////////////////////////////////////
             if (btTest.Name == "B1")
            {
                btTest.Text = "X";
                game[1, 0] = btTest.Text;
                moves++;
            }
             if (btTest.Name == "B2")
            {
                btTest.Text = "X";
                game[1, 1] = btTest.Text;
                moves++;
            }
             if (btTest.Name == "B3")
            {
                btTest.Text = "X";
                game[1, 2] = btTest.Text;
                moves++;
            }
            //////////////////////////////////////////////
             if (btTest.Name == "C1")
            {
                btTest.Text = "X";
                game[2, 0] = btTest.Text;
                moves++;
            }
             if (btTest.Name == "C2")
            {
                btTest.Text = "X";
                game[2, 1] = btTest.Text;
                moves++;
            }
             if (btTest.Name == "C3")
            {
                btTest.Text = "X";
                game[2, 2] = btTest.Text;
                moves++;
            }
            btTest.Enabled = false;
            bool checker = false;




            //first move
            if (first == 1)
            {
                if (game[1, 1] == "X")
                {
                    int d = new Random().Next(0, conners.Length);
                    if (conners[d] == "a1")
                    {
                        game[0, 0] = "O";
                        A1.Text = game[0, 0].ToString();
                        A1.Enabled = false;
                    }
                    else if (conners[d] == "a3")
                    {
                        game[0, 2] = "O";
                        A3.Text = game[0, 2].ToString();
                        A3.Enabled = false;
                    }
                    else if (conners[d] == "c1")
                    {
                        game[0, 2] = "O";
                        C1.Text = game[0, 2].ToString();
                        C1.Enabled = false;
                    }
                    else
                    {
                        game[2, 2] = "O";
                        C3.Text = game[2, 2].ToString();
                        C3.Enabled = false;
                    }
                }
                else
                {
                    game[1, 1] = "O";
                    B2.Text = game[1, 1].ToString();
                    B2.Enabled = false;
                }
            }
            //===========================================================================determining a winner================================================
            if (first != 1)
            {
                for (int p = 0; p < game.GetLength(0); p++)
                {
                    for (int d = 0; d < game.GetLength(1); d++)
                    {
                        if (game[0, 0] == "W" && game[0, 1] == "O" && game[0, 2] == "O" && checker == false)
                        {
                            game[0, 0] = "O";
                            A1.Text = game[0, 0].ToString();
                            A1.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 1] == "W" && game[0, 2] == "O" && game[0, 0] == "O" && checker == false)
                        {
                            game[0, 1] = "O";
                            A2.Text = game[0, 1].ToString();
                            A2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 2] == "W" && game[0, 0] == "O" && game[0, 1] == "O" && checker == false)
                        {
                            game[0, 2] = "O";
                            A3.Text = game[0, 2].ToString();
                            A3.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 0] == "W" && game[1, 0] == "O" && game[2, 0] == "O" && checker == false)
                        {
                            game[0, 0] = "O";
                            A1.Text = game[0, 0].ToString();
                            A1.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 0] == "W" && game[0, 0] == "O" && game[2, 0] == "O" && checker == false)
                        {
                            game[1, 0] = "O";
                            B1.Text = game[1, 0].ToString();
                            B1.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 0] == "W" && game[0, 0] == "O" && game[1, 0] == "O" && checker == false)
                        {
                            game[2, 0] = "O";
                            C1.Text = game[2, 0].ToString();
                            C1.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 0] == "O" && game[1, 1] == "W" && game[1, 2] == "O" && checker == false)
                        {
                            game[1, 1] = "O";
                            B2.Text = game[1, 1].ToString();
                            B2.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 1] == "O" && game[1, 0] == "W" && game[1, 2] == "O" && checker == false)
                        {
                            game[1, 0] = "O";
                            B1.Text = game[1, 1].ToString();
                            B1.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 1] == "O" && game[2, 0] == "W" && game[2, 2] == "O" && checker == false)
                        {
                            game[2, 0] = "O";
                            C1.Text = game[1, 1].ToString();
                            C1.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 2] == "O" && game[0, 2] == "W" && game[1, 2] == "O" && checker == false)
                        {
                            game[0, 2] = "O";
                            A3.Text = game[0, 2].ToString();
                            A3.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 0] == "O" && game[2, 1] == "W" && game[2, 2] == "O" && checker == false)
                        {
                            game[2, 1] = "O";
                            C2.Text = game[2, 1].ToString();
                            C2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 1] == "O" && game[2, 1] == "W" && game[1, 1] == "O" && checker == false)
                        {
                            game[2, 1] = "O";
                            C2.Text = game[2, 1].ToString();
                            C2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 1] == "O" && game[1, 1] == "W" && game[2, 1] == "O" && checker == false)
                        {
                            game[1, 1] = "O";
                            B2.Text = game[1, 1].ToString();
                            B2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 2] == "O" && game[1, 2] == "W" && game[2, 2] == "O" && checker == false)
                        {
                            game[1, 2] = "O";
                            B3.Text = game[1, 2].ToString();
                            B3.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 0] == "O" && game[1, 2] == "W" && game[1, 1] == "O" && checker == false)
                        {
                            game[1, 2] = "O";
                            B3.Text = game[1, 2].ToString();
                            B3.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 0] == "O" && game[2, 2] == "W" && game[2, 1] == "O" && checker == false)
                        {
                            game[2, 2] = "O";
                            C3.Text = game[2, 2].ToString();
                            C3.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 2] == "O" && game[2, 2] == "W" && game[1, 2] == "O" && checker == false)
                        {
                            game[2, 2] = "O";
                            C3.Text = game[2, 2].ToString();
                            C3.Enabled = false;
                            checker = true;
                        }

                        //START DIAGONAL WINNER:
                        else if (game[0, 0] == "O" && game[2, 2] == "W" && game[1, 1] == "O" && checker == false)
                        {
                            game[2, 2] = "O";
                            C3.Text = game[2, 2].ToString();
                            C3.Enabled = false;
                            checker = true;
                        }

                        else if (game[0, 0] == "W" && game[2, 2] == "O" && game[1, 1] == "O" && checker == false)
                        {
                            game[0, 0] = "O";
                            A1.Text = game[0, 0].ToString();
                            A1.Enabled = false;
                            checker = true;
                        }

                        else if (game[0, 0] == "O" && game[2, 2] == "O" && game[1, 1] == "W" && checker == false)
                        {
                            game[1, 1] = "O";
                            B2.Text = game[1, 1].ToString();
                            B2.Enabled = false;
                            checker = true;
                        }
                        ///////////END DIAGOAL WINNER:
                        else if (game[0, 2] == "O" && game[2, 0] == "W" && game[1, 1] == "O" && checker == false)
                        {
                            game[2, 0] = "O";
                            C1.Text = game[2, 0].ToString();
                            C1.Enabled = false;
                            checker = true;
                        }

                        else if (game[0, 2] == "O" && game[2, 0] == "O" && game[1, 1] == "W" && checker == false)
                        {
                            game[1, 1] = "O";
                            B2.Text = game[1, 1].ToString();
                            B2.Enabled = false;
                            checker = true;
                        }

                        else if (game[0, 2] == "W" && game[2, 0] == "O" && game[1, 1] == "O" && checker == false)
                        {
                            game[0, 2] = "O";
                            A3.Text = game[0, 2].ToString();
                            A3.Enabled = false;
                            checker = true;
                        }

                        ///START OTHER DIAGONAL WINNER
                        ///

                        //END OTHER DIAGONAL WINNER
                        else
                        {
                            if (checker == false)
                            {
                                for (int h = 0; h < game.GetLength(0); h++)
                                {
                                    for (int f = 0; f < game.GetLength(1); f++)
                                    {
                                        if (game[h, f] == "W" && checker == false)
                                        {
                                            if (h == 0 && f == 0)
                                            {
                                                game[h, f] = "O";
                                                A1.Text = game[h, f].ToString();
                                                A1.Enabled = false;
                                            }
                                            else if (h == 0 && f == 1)
                                            {
                                                game[h, f] = "O";
                                                A2.Text = game[h, f].ToString();
                                                A2.Enabled = false;
                                            }
                                            else if (h == 0 && f == 2)
                                            {
                                                game[h, f] = "O";
                                                A3.Text = game[h, f].ToString();
                                                A3.Enabled = false;
                                            }

                                            else if (h == 1 && f == 0)
                                            {
                                                game[h, f] = "O";
                                                B1.Text = game[h, f].ToString();
                                                B1.Enabled = false;
                                            }
                                            else if (h == 1 && f == 1)
                                            {
                                                game[h, f] = "O";
                                                B2.Text = game[h, f].ToString();
                                                B2.Enabled = false;
                                            }
                                            else if (h == 1 && f == 2)
                                            {
                                                game[h, f] = "O";
                                                B3.Text = game[h, f].ToString();
                                                B3.Enabled = false;
                                            }
                                            else if (h == 2 && f == 0)
                                            {
                                                game[h, f] = "O";
                                                C1.Text = game[h, f].ToString();
                                                C1.Enabled = false;
                                            }
                                            else if (h == 2 && f == 1)
                                            {
                                                game[h, f] = "O";
                                                C2.Text = game[h, f].ToString();
                                                C2.Enabled = false;
                                            }
                                            else if (h == 2 && f == 2)
                                            {
                                                game[h, f] = "O";
                                                C3.Text = game[h, f].ToString();
                                                C3.Enabled = false;
                                            }
                                            checker = true;

                                        }

                                    }
                                }
                                checker = true;
                            }
                        }
                    }
                }
                //}

            }
            //===========================================================================================================================================

            //defend
            if (first != 1)
            {
                for (int p = 0; p < game.GetLength(0); p++)
                {
                    for (int d = 0; d < game.GetLength(1); d++)
                    {
                        if (game[0, 0] == "W" && game[0, 1] == "X" && game[0, 2] == "X" && checker == false)
                        {
                            game[0, 0] = "O";
                            A1.Text = game[0, 0].ToString();
                            A1.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 1] == "W" && game[0, 2] == "X" && game[0, 0] == "X" && checker == false)
                        {
                            game[0, 1] = "O";
                            A2.Text = game[0, 1].ToString();
                            A2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 2] == "W" && game[0, 0] == "X" && game[0, 1] == "X" && checker == false)
                        {
                            game[0, 2] = "O";
                            A3.Text = game[0, 2].ToString();
                            A3.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 0] == "W" && game[1, 0] == "X" && game[2, 0] == "X" && checker == false)
                        {
                            game[0, 0] = "O";
                            A1.Text = game[0, 0].ToString();
                            A1.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 0] == "W" && game[0, 0] == "X" && game[2, 0] == "X" && checker == false)
                        {
                            game[1, 0] = "O";
                            B1.Text = game[1, 0].ToString();
                            B1.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 0] == "W" && game[0, 0] == "X" && game[1, 0] == "X" && checker == false)
                        {
                            game[2, 0] = "O";
                            C1.Text = game[2, 0].ToString();
                            C1.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 0] == "X" && game[1, 1] == "W" && game[1, 2] == "X" && checker == false)
                        {
                            game[1, 1] = "O";
                            B2.Text = game[1, 1].ToString();
                            B2.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 1] == "X" && game[1, 0] == "W" && game[1, 2] == "X" && checker == false)
                        {
                            game[1, 0] = "O";
                            B1.Text = game[1, 1].ToString();
                            B1.Enabled = false;
                            checker = true;
                        }
                        //START LAST DEFENISE
                        else if (game[2, 1] == "X" && game[2, 0] == "W" && game[2, 2] == "X" && checker == false)
                        {
                            game[2, 0] = "O";
                            // C1.Text = array[2, 1].ToString();

                            ///CHANGE
                            C1.Text = game[2, 0].ToString();
                            C1.Enabled = false;
                            checker = true;
                        }

                        else if (game[2, 1] == "W" && game[2, 0] == "X" && game[2, 2] == "X" && checker == false)
                        {
                            game[2, 1] = "O";
                            // C1.Text = array[2, 1].ToString();

                            ///CHANGE
                            C2.Text = game[2, 1].ToString();
                            C2.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 1] == "X" && game[2, 0] == "X" && game[2, 2] == "W" && checker == false)
                        {
                            game[2, 2] = "O";
                            // C1.Text = array[2, 1].ToString();

                            ///CHANGE
                            C3.Text = game[2, 2].ToString();
                            C3.Enabled = false;
                            checker = true;
                        }
                        ///END LAST DEFENSIVE:
                        else if (game[2, 2] == "X" && game[0, 2] == "W" && game[1, 2] == "X" && checker == false)
                        {
                            game[0, 2] = "O";
                            A3.Text = game[0, 2].ToString();
                            A3.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 0] == "X" && game[2, 1] == "W" && game[2, 2] == "X" && checker == false)
                        {
                            game[2, 1] = "O";
                            C2.Text = game[2, 1].ToString();
                            C2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 1] == "X" && game[2, 1] == "W" && game[1, 1] == "X" && checker == false)
                        {
                            game[2, 1] = "O";
                            C2.Text = game[2, 1].ToString();
                            C2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 1] == "X" && game[1, 1] == "W" && game[2, 1] == "X" && checker == false)
                        {
                            game[1, 1] = "O";
                            B2.Text = game[1, 1].ToString();
                            B2.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 2] == "X" && game[1, 2] == "W" && game[2, 2] == "X" && checker == false)
                        {
                            game[1, 2] = "O";
                            B3.Text = game[1, 2].ToString();
                            B3.Enabled = false;
                            checker = true;
                        }
                        else if (game[1, 0] == "X" && game[1, 2] == "W" && game[1, 1] == "X" && checker == false)
                        {
                            game[1, 2] = "O";
                            B3.Text = game[1, 2].ToString();
                            B3.Enabled = false;
                            checker = true;
                        }
                        else if (game[2, 0] == "X" && game[2, 2] == "W" && game[2, 1] == "X" && checker == false)
                        {
                            game[2, 2] = "O";
                            C3.Text = game[2, 2].ToString();
                            C3.Enabled = false;
                            checker = true;
                        }
                        else if (game[0, 2] == "X" && game[2, 2] == "W" && game[1, 2] == "X" && checker == false)
                        {
                            game[2, 2] = "O";
                            C3.Text = game[2, 2].ToString();
                            C3.Enabled = false;
                            checker = true;
                        }
                        else
                        {
                            if (checker == false)
                            {
                                for (int h = 0; h < game.GetLength(0); h++)
                                {
                                    for (int f = 0; f < game.GetLength(1); f++)
                                    {
                                        if (game[h, f] == "W" && checker == false)
                                        {
                                            if (h == 0 && f == 0)
                                            {
                                                game[h, f] = "O";
                                                A1.Text = game[h, f].ToString();
                                                A1.Enabled = false;
                                            }
                                            else if (h == 0 && f == 1)
                                            {
                                                game[h, f] = "O";
                                                A2.Text = game[h, f].ToString();
                                                A2.Enabled = false;
                                            }
                                            else if (h == 0 && f == 2)
                                            {
                                                game[h, f] = "O";
                                                A3.Text = game[h, f].ToString();
                                                A3.Enabled = false;
                                            }

                                            else if (h == 1 && f == 0)
                                            {
                                                game[h, f] = "O";
                                                B1.Text = game[h, f].ToString();
                                                B1.Enabled = false;
                                            }
                                            else if (h == 1 && f == 1)
                                            {
                                                game[h, f] = "O";
                                                B2.Text = game[h, f].ToString();
                                                B2.Enabled = false;
                                            }
                                            else if (h == 1 && f == 2)
                                            {
                                                game[h, f] = "O";
                                                B3.Text = game[h, f].ToString();
                                                B3.Enabled = false;
                                            }
                                            else if (h == 2 && f == 0)
                                            {
                                                game[h, f] = "O";
                                                C1.Text = game[h, f].ToString();
                                                C1.Enabled = false;
                                            }
                                            else if (h == 2 && f == 1)
                                            {
                                                game[h, f] = "O";
                                                C2.Text = game[h, f].ToString();
                                                C2.Enabled = false;
                                            }
                                            else if (h == 2 && f == 2)
                                            {
                                                game[h, f] = "O";
                                                C3.Text = game[h, f].ToString();
                                                C3.Enabled = false;
                                            }
                                            checker = true;

                                        }

                                    }
                                }
                                checker = true;
                            }
                        }
                    }
                }
                //}

            }
            //COMPUTER MOVES

            if (moves > 2)
            {
                if (A1.Text == A2.Text && A2.Text == A3.Text)
                {
                    theWinner = true;
                        winner = game[0, 0].ToString();
                }
                 if (B1.Text == B2.Text && B2.Text == B3.Text)
                {
                    theWinner = true;
                    winner = game[1, 0].ToString();
                }
                 if (C1.Text == C2.Text && C2.Text == C3.Text)
                {
                    theWinner = true;
                    
                    winner = game[1, 0].ToString();
                }
                 if (A1.Text == B1.Text && B1.Text == C1.Text)
                {
                    theWinner = true;
                    winner = game[1, 0].ToString();
                }
                 if (A2.Text == B2.Text && B2.Text == C2.Text)
                {
                    theWinner = true;
                    winner = B2.Text;
                }
                 if (A3.Text == B3.Text && B3.Text == C3.Text)
                {
                    theWinner = true;
                    
                    winner = B3.Text;
                }
                 if (A1.Text == B2.Text && B2.Text == C3.Text)
                {
                    theWinner = true;
                    winner = A1.Text;
                }
                 if (A3.Text == B2.Text && B2.Text == C1.Text)
                {
                    theWinner = true;
                    winner = A3.Text;
                }




            }
            bool Draw = false;

            if (theWinner)
            {
                MessageBox.Show(winner.ToString() + " Winner" );
                Application.Restart();
            }
            else
            {
                for (int r = 0; r < game.GetLength(0); r++)
                {
                    for (int c = 0; c < game.GetLength(1); c++)
                    {
                        if (game[r, c] != "W" && moves == 5)
                        {
                            Draw = true;
                        }
                    }
                }
            }

            if (Draw == true)
                MessageBox.Show("Draw");


        }

   

      
     
    }
}
