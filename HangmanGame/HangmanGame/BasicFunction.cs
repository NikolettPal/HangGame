using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace HangmanGame
//{
//    public class BasicFunction
//    {
//        public static string actual = "";
//        public static string backed = "";
//        public static int rossz_ak = 0;

//        private void kepek()
//        {
//            rossz_ak++;

//            if (rossz_ak == 1)
//            {
//                pictureBox1.Image = Image.FromFile("0.png");
//            }
//            else if (rossz_ak == 2)
//            {
//                pictureBox1.Image = Image.FromFile("1.png");
//            }
//            else if (rossz_ak == 3)
//            {
//                pictureBox1.Image = Image.FromFile("2.png");
//            }
//            else if (rossz_ak == 4)
//            {
//                pictureBox1.Image = Image.FromFile("3.png");
//            }
//            else if (rossz_ak == 5)
//            {
//                pictureBox1.Image = Image.FromFile("4.png");
//            }
//            else if (rossz_ak == 6)
//            {
//                pictureBox1.Image = Image.FromFile("5.png");
//            }
//            else if (rossz_ak == 7)
//            {
//                pictureBox1.Image = Image.FromFile("6.png");
//            }
//            else if (rossz_ak == 8)
//            {
//                pictureBox1.Image = Image.FromFile("7.png");
//            }
//            else if (rossz_ak == 9)
//            {
//                pictureBox1.Image = Image.FromFile("8.png");
//            }
//            else if (rossz_ak == 10)
//            {
//                pictureBox1.Image = Image.FromFile("9.png");
//            }
//            else if (rossz_ak == 11)
//            {
//                pictureBox1.Image = Image.FromFile("10.png");
//            }
//            else if (rossz_ak == 12)
//            {
//                pictureBox1.Image = Image.FromFile("11.png");
//            }

//            else if (rossz_ak == 13)
//            {
//                pictureBox1.Image = Image.FromFile("12.png");
//                //betukeltunese();
//                //vegsoelemek_vereseg();
//            }
//        }

//        private void betukeltunese()
//        {
//            A.Visible = false;
//            B.Visible = false;
//            C.Visible = false;
//            D.Visible = false;
//            E.Visible = false;
//            F.Visible = false;
//            G.Visible = false;
//            H.Visible = false;
//            I.Visible = false;
//            J.Visible = false;
//            K.Visible = false;
//            L.Visible = false;
//            M.Visible = false;
//            N.Visible = false;
//            O.Visible = false;
//            P.Visible = false;
//            Q.Visible = false;
//            R.Visible = false;
//            S.Visible = false;
//            T.Visible = false;
//            U.Visible = false;
//            V.Visible = false;
//            W.Visible = false;
//            X.Visible = false;
//            Y.Visible = false;
//            Z.Visible = false;
//        }

//        private void betukmegjelenese()
//        {
//            A.Visible = true;
//            B.Visible = true;
//            C.Visible = true;
//            D.Visible = true;
//            E.Visible = true;
//            F.Visible = true;
//            G.Visible = true;
//            H.Visible = true;
//            I.Visible = true;
//            J.Visible = true;
//            K.Visible = true;
//            L.Visible = true;
//            M.Visible = true;
//            N.Visible = true;
//            O.Visible = true;
//            P.Visible = true;
//            Q.Visible = true;
//            R.Visible = true;
//            S.Visible = true;
//            T.Visible = true;
//            U.Visible = true;
//            V.Visible = true;
//            W.Visible = true;
//            X.Visible = true;
//            Y.Visible = true;
//            Z.Visible = true;
//        }

//        private void RandomGeneraltSzam()
//        {
//            string[] szavak = System.IO.File.ReadAllLines("words.txt");
//            Random randomNumber = new Random();
//            string valasztott = szavak[randomNumber.Next(szavak.Length)].ToUpper();
//            actual = valasztott;
//        }
//        private void ElsoLepes()
//        {
//            RandomGeneraltSzam();

//            for (short i = 0; i < actual.Length; i++)
//            {
//                backed += "_";
//            }
//            MasodikLepes();
//        }
//        private void MasodikLepes()
//        {
//            for (short i = 0; i < backed.Length; i++)
//            {
//                kitalalando.Text += backed.Substring(i, 1);
//                kitalalando.Text += " ";
//            }
//        }

//        private void Akasztofa_Load(object sender, EventArgs e)
//        {
//            RandomGeneraltSzam();
//            ElsoLepes();
//        }


//        private void lbl_click(object sender, EventArgs e)
//        {
//            char[] tipp = backed.ToCharArray();
//            char[] asd = actual.ToCharArray();
//            char[] win = { '_' };

//            Label jk = sender as Label; //Label jk = (label) sender;

//            char[] gomb = jk.Text.ToCharArray();

//            if (actual.Contains(jk.Text))
//            {
//                for (short i = 0; i < asd.Length; i++)
//                {
//                    if (asd[i] == gomb[0])
//                    {
//                        tipp[i] = gomb[0];
//                    }
//                }

//                backed = new string(tipp);
//                kitalalando.Text = "";

//                for (int i = 0; i < backed.Length; i++)
//                {
//                    kitalalando.Text += backed.Substring(i, 1);
//                    kitalalando.Text += " ";
//                }

//                jk.Visible = false;
//            }
//            else
//            {
//                jk.Visible = false;
//                hibasBetuk.Text += (jk.Text) + (" ");
//                kepek();
//            }

//            //if (!backed.Contains('_'))
//            //{
//            //    betukeltunese();
//            //    pictureBox1.Image = Image.FromFile(win.png);
//            //    win_lbl.Visible = true;
//            //    hibasBetuk.Visible = false;
//            //    New_game_lbl.Visible = true;


//            //}


//        }



//        private void exit_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void newGame_Click(object sender, EventArgs e)
//        {
//            Application.Restart();
//        }

//    }
//}
