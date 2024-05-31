namespace Flappy_Bird_WINFORM
{
    partial class Form1
    {

        // Required designer variable.

        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.

        // true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        // InitializeComponent() -> Required method for Designer support - do not modify
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.DownPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.ScorePoint = new System.Windows.Forms.Label();
            this.DownPipe2 = new System.Windows.Forms.PictureBox();
            this.TopPipe2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(12, 236);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(83, 69);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;    
            // 
            // DownPipe
            // 
            this.DownPipe.Image = ((System.Drawing.Image)(resources.GetObject("DownPipe.Image")));
            this.DownPipe.Location = new System.Drawing.Point(256, 378);
            this.DownPipe.Name = "DownPipe";
            this.DownPipe.Size = new System.Drawing.Size(100, 300);
            this.DownPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe.TabIndex = 1;
            this.DownPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-3, 542);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(718, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // TopPipe
            // 
            this.TopPipe.Image = ((System.Drawing.Image)(resources.GetObject("TopPipe.Image")));
            this.TopPipe.Location = new System.Drawing.Point(256, -76);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(100, 270);
            this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe.TabIndex = 3;
            this.TopPipe.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.SkyTimer);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.NavajoWhite;
            this.Score.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(2, 556);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(86, 30);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:";
            // 
            // ScorePoint
            // 
            this.ScorePoint.AutoSize = true;
            this.ScorePoint.BackColor = System.Drawing.Color.NavajoWhite;
            this.ScorePoint.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePoint.Location = new System.Drawing.Point(84, 556);
            this.ScorePoint.Name = "ScorePoint";
            this.ScorePoint.Size = new System.Drawing.Size(27, 30);
            this.ScorePoint.TabIndex = 6;
            this.ScorePoint.Text = "0";
            // 
            // DownPipe2
            // 
            this.DownPipe2.Image = ((System.Drawing.Image)(resources.GetObject("DownPipe2.Image")));
            this.DownPipe2.Location = new System.Drawing.Point(602, 309);
            this.DownPipe2.Name = "DownPipe2";
            this.DownPipe2.Size = new System.Drawing.Size(100, 350);
            this.DownPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe2.TabIndex = 7;
            this.DownPipe2.TabStop = false;
            // 
            // TopPipe2
            // 
            this.TopPipe2.Image = ((System.Drawing.Image)(resources.GetObject("TopPipe2.Image")));
            this.TopPipe2.Location = new System.Drawing.Point(602, -149);
            this.TopPipe2.Name = "TopPipe2";
            this.TopPipe2.Size = new System.Drawing.Size(100, 270);
            this.TopPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe2.TabIndex = 8;
            this.TopPipe2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(714, 591);
            this.Controls.Add(this.TopPipe2);
            this.Controls.Add(this.ScorePoint);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.TopPipe);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.DownPipe);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.DownPipe2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox DownPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox TopPipe;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScorePoint;
        private System.Windows.Forms.PictureBox DownPipe2;
        private System.Windows.Forms.PictureBox TopPipe2;
    }
}
