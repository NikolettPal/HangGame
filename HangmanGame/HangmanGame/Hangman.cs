using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangmanGame
{
    public partial class Hangman : Form
    {
        public static string actualWord = "";
        public static string backedWord = "";
        public static int numberOfWrongTips = 0;

        public Hangman()
        {
            InitializeComponent();
        }

        private void BuildGallowsTree()
        {
            numberOfWrongTips++;

            if (numberOfWrongTips == 1)
            {
                pictureBox1.Image = Image.FromFile("0.png");
            }
            else if (numberOfWrongTips == 2)
            {
                pictureBox1.Image = Image.FromFile("1.png");
            }
            else if (numberOfWrongTips == 3)
            {
                pictureBox1.Image = Image.FromFile("2.png");
            }
            else if (numberOfWrongTips == 4)
            {
                pictureBox1.Image = Image.FromFile("3.png");
            }
            else if (numberOfWrongTips == 5)
            {
                pictureBox1.Image = Image.FromFile("4.png");
            }
            else if (numberOfWrongTips == 6)
            {
                pictureBox1.Image = Image.FromFile("5.png");
            }
            else if (numberOfWrongTips == 7)
            {
                pictureBox1.Image = Image.FromFile("6.png");
            }
            else if (numberOfWrongTips == 8)
            {
                pictureBox1.Image = Image.FromFile("7.png");
            }
            else if (numberOfWrongTips == 9)
            {
                pictureBox1.Image = Image.FromFile("8.png");
            }
            else if (numberOfWrongTips == 10)
            {
                pictureBox1.Image = Image.FromFile("9.png");
            }
            else if (numberOfWrongTips == 11)
            {
                pictureBox1.Image = Image.FromFile("10.png");
            }
            else if (numberOfWrongTips == 12)
            {
                pictureBox1.Image = Image.FromFile("11.png");
            }

            else if (numberOfWrongTips == 13)
            {
                pictureBox1.Image = Image.FromFile("12.png");
                //LetterAbolishing();
                //vegsoelemek_vereseg();
            }
        }
        //private void LetterAbolishing()
        //{
        //    A.Visible = false;
        //    B.Visible = false;
        //    C.Visible = false;
        //    D.Visible = false;
        //    E.Visible = false;
        //    F.Visible = false;
        //    G.Visible = false;
        //    H.Visible = false;
        //    I.Visible = false;
        //    J.Visible = false;
        //    K.Visible = false;
        //    L.Visible = false;
        //    M.Visible = false;
        //    N.Visible = false;
        //    O.Visible = false;
        //    P.Visible = false;
        //    Q.Visible = false;
        //    R.Visible = false;
        //    S.Visible = false;
        //    T.Visible = false;
        //    U.Visible = false;
        //    V.Visible = false;
        //    W.Visible = false;
        //    X.Visible = false;
        //    Y.Visible = false;
        //    Z.Visible = false;
        //}
        //private void DisplayOfLetters()
        //{
        //    A.Visible = true;
        //    B.Visible = true;
        //    C.Visible = true;
        //    D.Visible = true;
        //    E.Visible = true;
        //    F.Visible = true;
        //    G.Visible = true;
        //    H.Visible = true;
        //    I.Visible = true;
        //    J.Visible = true;
        //    K.Visible = true;
        //    L.Visible = true;
        //    M.Visible = true;
        //    N.Visible = true;
        //    O.Visible = true;
        //    P.Visible = true;
        //    Q.Visible = true;
        //    R.Visible = true;
        //    S.Visible = true;
        //    T.Visible = true;
        //    U.Visible = true;
        //    V.Visible = true;
        //    W.Visible = true;
        //    X.Visible = true;
        //    Y.Visible = true;
        //    Z.Visible = true;
        //}

        private void RandomGenerator()
        {
            string[] wordlist = System.IO.File.ReadAllLines("words.txt");
            Random random = new Random();
            string randomSelectedWord = wordlist[random.Next(wordlist.Length)].ToUpper();
            actualWord = randomSelectedWord;
        }
        private void ChoosingARandomWordAndCountingItsCharacters()
        {
            RandomGenerator();

            for (short i = 0; i < actualWord.Length; i++)
            {
                backedWord += "_";
            }
            SeparatingTheUnderScoresWithSpaces();
        }
        private void SeparatingTheUnderScoresWithSpaces()
        {
            for (short i = 0; i < backedWord.Length; i++)
            {
                guessedWord.Text += backedWord.Substring(i,1);
                guessedWord.Text += " ";
            }
        }

        private void Hangman_Load_1(object sender, EventArgs e)
        {
            RandomGenerator();
            ChoosingARandomWordAndCountingItsCharacters();
        }



        private void Letter_Click(object sender, EventArgs e)
        {
            char[] tipp = backedWord.ToCharArray();
            char[] asd = actualWord.ToCharArray();
            char[] win = { '_' };

            Label jk = sender as Label; //Label jk = (label) sender;

            char[] gomb = jk.Text.ToCharArray();

            if (actualWord.Contains(jk.Text))
            {
                for (short i = 0; i < asd.Length; i++)
                {
                    if (asd[i] == gomb[0])
                    {
                        tipp[i] = gomb[0];
                    }
                }

                backedWord = new string(tipp);
                guessedWord.Text = "";

                for (int i = 0; i < backedWord.Length; i++)
                {
                    guessedWord.Text += backedWord.Substring(i, 1);
                    guessedWord.Text += " ";
                }

                jk.Visible = false;
            }
            else
            {
                jk.Visible = false;
                hibasBetuk.Text += (jk.Text) + (" ");
                BuildGallowsTree();
            }

            //if (!masoltJelenlegi.Contains('_'))
            //{
            //    betukeltunese();
            //    pictureBox1.Image = Image.FromFile(win.png);
            //    win_lbl.Visible = true;
            //    hibasBetuk.Visible = false;
            //    New_game_lbl.Visible = true;


            //}


        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }
}
