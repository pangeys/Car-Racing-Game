namespace Car_Racing_Game_
{
    partial class CarRacing
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.roadtrack2 = new System.Windows.Forms.PictureBox();
            this.roadtrack1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.roadtrack2);
            this.panel1.Controls.Add(this.roadtrack1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStart.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(134, 551);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textScore.Location = new System.Drawing.Point(166, 520);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(105, 28);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::Car_Racing_Game_.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(79, 331);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(60, 44);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.BackColor = System.Drawing.Color.Brown;
            this.award.Image = global::Car_Racing_Game_.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(0, 165);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(447, 117);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Car_Racing_Game_.Properties.Resources.white;
            this.player.Location = new System.Drawing.Point(191, 376);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 120);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // A2
            // 
            this.A2.Image = global::Car_Racing_Game_.Properties.Resources.yellow;
            this.A2.Location = new System.Drawing.Point(292, 111);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(60, 120);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 3;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // A1
            // 
            this.A1.Image = global::Car_Racing_Game_.Properties.Resources.blue3;
            this.A1.Location = new System.Drawing.Point(62, 39);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(60, 120);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 2;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // roadtrack2
            // 
            this.roadtrack2.Image = global::Car_Racing_Game_.Properties.Resources.Roadtrack;
            this.roadtrack2.Location = new System.Drawing.Point(-200, 0);
            this.roadtrack2.Name = "roadtrack2";
            this.roadtrack2.Size = new System.Drawing.Size(844, 500);
            this.roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack2.TabIndex = 1;
            this.roadtrack2.TabStop = false;
            // 
            // roadtrack1
            // 
            this.roadtrack1.Image = global::Car_Racing_Game_.Properties.Resources.Roadtrack;
            this.roadtrack1.Location = new System.Drawing.Point(-200, -500);
            this.roadtrack1.Name = "roadtrack1";
            this.roadtrack1.Size = new System.Drawing.Size(844, 500);
            this.roadtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack1.TabIndex = 0;
            this.roadtrack1.TabStop = false;
            // 
            // CarRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 610);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "CarRacing";
            this.Text = "CAR RACING GAME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox roadtrack1;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox roadtrack2;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}

