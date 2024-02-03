namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BoruUst = new PictureBox();
            BoruAlt = new PictureBox();
            Zemin = new PictureBox();
            flappyBird = new PictureBox();
            label1 = new Label();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            SuspendLayout();
            // 
            // BoruUst
            // 
            BoruUst.Image = (Image)resources.GetObject("BoruUst.Image");
            BoruUst.Location = new Point(426, -1);
            BoruUst.Name = "BoruUst";
            BoruUst.Size = new Size(77, 139);
            BoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruUst.TabIndex = 0;
            BoruUst.TabStop = false;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(356, 314);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(84, 144);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 1;
            BoruAlt.TabStop = false;
            // 
            // Zemin
            // 
            Zemin.Image = (Image)resources.GetObject("Zemin.Image");
            Zemin.Location = new Point(-1, 455);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(561, 57);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 2;
            Zemin.TabStop = false;
            Zemin.Click += pictureBox3_Click;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(31, 191);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(80, 57);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 3;
            flappyBird.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(31, 515);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(111, 37);
            scoreText.TabIndex = 5;
            scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(561, 549);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(label1);
            Controls.Add(Zemin);
            Controls.Add(BoruAlt);
            Controls.Add(BoruUst);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            DpiChanged += Form1_DpiChanged;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)BoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoruUst;
        private PictureBox BoruAlt;
        private PictureBox Zemin;
        private PictureBox flappyBird;
        private Label label1;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}