namespace HangmanGame
{
    partial class Hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hibasBetuk = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.Label();
            this.J = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.guessedWord = new System.Windows.Forms.Label();
            this.EN = new System.Windows.Forms.Button();
            this.DE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(592, 26);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 63;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(684, 26);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 23);
            this.Exit.TabIndex = 62;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(458, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 220);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // hibasBetuk
            // 
            this.hibasBetuk.AutoSize = true;
            this.hibasBetuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hibasBetuk.Location = new System.Drawing.Point(260, 265);
            this.hibasBetuk.Name = "hibasBetuk";
            this.hibasBetuk.Size = new System.Drawing.Size(0, 20);
            this.hibasBetuk.TabIndex = 60;
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.W.Location = new System.Drawing.Point(87, 274);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(24, 20);
            this.W.TabIndex = 58;
            this.W.Text = "W";
            this.W.Click += new System.EventHandler(this.Letter_Click);
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.V.Location = new System.Drawing.Point(68, 274);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(20, 20);
            this.V.TabIndex = 57;
            this.V.Text = "V";
            this.V.Click += new System.EventHandler(this.Letter_Click);
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.U.Location = new System.Drawing.Point(47, 274);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(21, 20);
            this.U.TabIndex = 56;
            this.U.Text = "U";
            this.U.Click += new System.EventHandler(this.Letter_Click);
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Z.Location = new System.Drawing.Point(148, 274);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(19, 20);
            this.Z.TabIndex = 55;
            this.Z.Text = "Z";
            this.Z.Click += new System.EventHandler(this.Letter_Click);
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Y.Location = new System.Drawing.Point(131, 274);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(20, 20);
            this.Y.TabIndex = 54;
            this.Y.Text = "Y";
            this.Y.Click += new System.EventHandler(this.Letter_Click);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X.Location = new System.Drawing.Point(111, 274);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(20, 20);
            this.X.TabIndex = 53;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.Letter_Click);
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.T.Location = new System.Drawing.Point(225, 250);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(18, 20);
            this.T.TabIndex = 52;
            this.T.Text = "T";
            this.T.Click += new System.EventHandler(this.Letter_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.S.Location = new System.Drawing.Point(205, 250);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(20, 20);
            this.S.TabIndex = 51;
            this.S.Text = "S";
            this.S.Click += new System.EventHandler(this.Letter_Click);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.R.Location = new System.Drawing.Point(189, 250);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(21, 20);
            this.R.TabIndex = 50;
            this.R.Text = "R";
            this.R.Click += new System.EventHandler(this.Letter_Click);
            // 
            // Q
            // 
            this.Q.AutoSize = true;
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Q.Location = new System.Drawing.Point(168, 250);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(21, 20);
            this.Q.TabIndex = 49;
            this.Q.Text = "Q";
            this.Q.Click += new System.EventHandler(this.Letter_Click);
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P.Location = new System.Drawing.Point(148, 250);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(19, 20);
            this.P.TabIndex = 48;
            this.P.Text = "P";
            this.P.Click += new System.EventHandler(this.Letter_Click);
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.O.Location = new System.Drawing.Point(128, 250);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(21, 20);
            this.O.TabIndex = 47;
            this.O.Text = "O";
            this.O.Click += new System.EventHandler(this.Letter_Click);
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N.Location = new System.Drawing.Point(107, 250);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(20, 20);
            this.N.TabIndex = 46;
            this.N.Text = "N";
            this.N.Click += new System.EventHandler(this.Letter_Click);
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.M.Location = new System.Drawing.Point(87, 250);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(22, 20);
            this.M.TabIndex = 45;
            this.M.Text = "M";
            this.M.Click += new System.EventHandler(this.Letter_Click);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L.Location = new System.Drawing.Point(68, 250);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(18, 20);
            this.L.TabIndex = 44;
            this.L.Text = "L";
            this.L.Click += new System.EventHandler(this.Letter_Click);
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.K.Location = new System.Drawing.Point(47, 250);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(19, 20);
            this.K.TabIndex = 43;
            this.K.Text = "K";
            this.K.Click += new System.EventHandler(this.Letter_Click);
            // 
            // J
            // 
            this.J.AutoSize = true;
            this.J.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.J.Location = new System.Drawing.Point(225, 228);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(17, 20);
            this.J.TabIndex = 42;
            this.J.Text = "J";
            this.J.Click += new System.EventHandler(this.Letter_Click);
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.I.Location = new System.Drawing.Point(209, 228);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(14, 20);
            this.I.TabIndex = 41;
            this.I.Text = "I";
            this.I.Click += new System.EventHandler(this.Letter_Click);
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.H.Location = new System.Drawing.Point(188, 228);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(21, 20);
            this.H.TabIndex = 40;
            this.H.Text = "H";
            this.H.Click += new System.EventHandler(this.Letter_Click);
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.G.Location = new System.Drawing.Point(167, 228);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(22, 20);
            this.G.TabIndex = 39;
            this.G.Text = "G";
            this.G.Click += new System.EventHandler(this.Letter_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.F.Location = new System.Drawing.Point(148, 228);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(19, 20);
            this.F.TabIndex = 38;
            this.F.Text = "F";
            this.F.Click += new System.EventHandler(this.Letter_Click);
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.E.Location = new System.Drawing.Point(128, 228);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(20, 20);
            this.E.TabIndex = 37;
            this.E.Text = "E";
            this.E.Click += new System.EventHandler(this.Letter_Click);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.D.Location = new System.Drawing.Point(107, 228);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(21, 20);
            this.D.TabIndex = 36;
            this.D.Text = "D";
            this.D.Click += new System.EventHandler(this.Letter_Click);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C.Location = new System.Drawing.Point(87, 228);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(20, 20);
            this.C.TabIndex = 35;
            this.C.Text = "C";
            this.C.Click += new System.EventHandler(this.Letter_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B.Location = new System.Drawing.Point(67, 228);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(20, 20);
            this.B.TabIndex = 34;
            this.B.Text = "B";
            this.B.Click += new System.EventHandler(this.Letter_Click);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A.Location = new System.Drawing.Point(49, 228);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(20, 20);
            this.A.TabIndex = 33;
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.Letter_Click);
            // 
            // guessedWord
            // 
            this.guessedWord.AutoSize = true;
            this.guessedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessedWord.Location = new System.Drawing.Point(53, 74);
            this.guessedWord.Name = "guessedWord";
            this.guessedWord.Size = new System.Drawing.Size(0, 20);
            this.guessedWord.TabIndex = 64;
            // 
            // EN
            // 
            this.EN.Image = ((System.Drawing.Image)(resources.GetObject("EN.Image")));
            this.EN.Location = new System.Drawing.Point(581, 286);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(36, 23);
            this.EN.TabIndex = 65;
            this.EN.UseVisualStyleBackColor = true;
            // 
            // DE
            // 
            this.DE.Image = ((System.Drawing.Image)(resources.GetObject("DE.Image")));
            this.DE.Location = new System.Drawing.Point(702, 286);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(36, 23);
            this.DE.TabIndex = 66;
            this.DE.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(458, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.guessedWord);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hibasBetuk);
            this.Controls.Add(this.W);
            this.Controls.Add(this.V);
            this.Controls.Add(this.U);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.T);
            this.Controls.Add(this.S);
            this.Controls.Add(this.R);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.P);
            this.Controls.Add(this.O);
            this.Controls.Add(this.N);
            this.Controls.Add(this.M);
            this.Controls.Add(this.L);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.I);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 360);
            this.MinimumSize = new System.Drawing.Size(800, 360);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hibasBetuk;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label Q;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.Label J;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label guessedWord;
        private System.Windows.Forms.Button EN;
        private System.Windows.Forms.Button DE;
        private System.Windows.Forms.Button button1;
    }
}

