namespace ArenaSoccer
{
    partial class ArenaSoccer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArenaSoccer));
            this.screen = new System.Windows.Forms.Panel();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ceiling = new System.Windows.Forms.PictureBox();
            this.player1ScoreLbl = new System.Windows.Forms.Label();
            this.player2ScoreLbl = new System.Windows.Forms.Label();
            this.wallForGoal1 = new System.Windows.Forms.PictureBox();
            this.wallForGoal2 = new System.Windows.Forms.PictureBox();
            this.goal1 = new System.Windows.Forms.PictureBox();
            this.goal2 = new System.Windows.Forms.PictureBox();
            this.player2Picturebox = new System.Windows.Forms.PictureBox();
            this.player1PictureBox = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ballOvalShape = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.blueWinsLbl = new System.Windows.Forms.Label();
            this.redWinsLbl = new System.Windows.Forms.Label();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceiling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallForGoal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallForGoal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.Controls.Add(this.redWinsLbl);
            this.screen.Controls.Add(this.blueWinsLbl);
            this.screen.Controls.Add(this.gameOverLbl);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.ceiling);
            this.screen.Controls.Add(this.player1ScoreLbl);
            this.screen.Controls.Add(this.player2ScoreLbl);
            this.screen.Controls.Add(this.wallForGoal1);
            this.screen.Controls.Add(this.wallForGoal2);
            this.screen.Controls.Add(this.goal1);
            this.screen.Controls.Add(this.goal2);
            this.screen.Controls.Add(this.player2Picturebox);
            this.screen.Controls.Add(this.player1PictureBox);
            this.screen.Controls.Add(this.shapeContainer1);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(980, 417);
            this.screen.TabIndex = 0;
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLbl.Location = new System.Drawing.Point(388, 62);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(181, 176);
            this.gameOverLbl.TabIndex = 14;
            this.gameOverLbl.Text = "\r\n\r\nF1 - Restart\r\nEsc - Exit";
            this.gameOverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(319, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 59);
            this.label1.TabIndex = 13;
            this.label1.Text = "The Fire Dome";
            // 
            // ceiling
            // 
            this.ceiling.BackColor = System.Drawing.Color.Black;
            this.ceiling.Location = new System.Drawing.Point(99, 0);
            this.ceiling.Name = "ceiling";
            this.ceiling.Size = new System.Drawing.Size(783, 50);
            this.ceiling.TabIndex = 12;
            this.ceiling.TabStop = false;
            // 
            // player1ScoreLbl
            // 
            this.player1ScoreLbl.AutoSize = true;
            this.player1ScoreLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player1ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLbl.ForeColor = System.Drawing.Color.Red;
            this.player1ScoreLbl.Location = new System.Drawing.Point(908, 9);
            this.player1ScoreLbl.Name = "player1ScoreLbl";
            this.player1ScoreLbl.Size = new System.Drawing.Size(51, 55);
            this.player1ScoreLbl.TabIndex = 11;
            this.player1ScoreLbl.Text = "0";
            // 
            // player2ScoreLbl
            // 
            this.player2ScoreLbl.AutoSize = true;
            this.player2ScoreLbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player2ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.player2ScoreLbl.Location = new System.Drawing.Point(21, 9);
            this.player2ScoreLbl.Name = "player2ScoreLbl";
            this.player2ScoreLbl.Size = new System.Drawing.Size(51, 55);
            this.player2ScoreLbl.TabIndex = 10;
            this.player2ScoreLbl.Text = "0";
            // 
            // wallForGoal1
            // 
            this.wallForGoal1.BackColor = System.Drawing.Color.Black;
            this.wallForGoal1.Location = new System.Drawing.Point(879, 0);
            this.wallForGoal1.Name = "wallForGoal1";
            this.wallForGoal1.Size = new System.Drawing.Size(107, 265);
            this.wallForGoal1.TabIndex = 9;
            this.wallForGoal1.TabStop = false;
            // 
            // wallForGoal2
            // 
            this.wallForGoal2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wallForGoal2.Location = new System.Drawing.Point(-6, 0);
            this.wallForGoal2.Name = "wallForGoal2";
            this.wallForGoal2.Size = new System.Drawing.Size(107, 265);
            this.wallForGoal2.TabIndex = 8;
            this.wallForGoal2.TabStop = false;
            // 
            // goal1
            // 
            this.goal1.BackColor = System.Drawing.Color.White;
            this.goal1.Image = ((System.Drawing.Image)(resources.GetObject("goal1.Image")));
            this.goal1.Location = new System.Drawing.Point(880, 262);
            this.goal1.Name = "goal1";
            this.goal1.Size = new System.Drawing.Size(100, 155);
            this.goal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goal1.TabIndex = 5;
            this.goal1.TabStop = false;
            // 
            // goal2
            // 
            this.goal2.BackColor = System.Drawing.Color.Transparent;
            this.goal2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goal2.BackgroundImage")));
            this.goal2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goal2.Location = new System.Drawing.Point(0, 262);
            this.goal2.Name = "goal2";
            this.goal2.Size = new System.Drawing.Size(100, 155);
            this.goal2.TabIndex = 4;
            this.goal2.TabStop = false;
            // 
            // player2Picturebox
            // 
            this.player2Picturebox.BackColor = System.Drawing.Color.Teal;
            this.player2Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("player2Picturebox.Image")));
            this.player2Picturebox.Location = new System.Drawing.Point(228, 368);
            this.player2Picturebox.Name = "player2Picturebox";
            this.player2Picturebox.Size = new System.Drawing.Size(40, 46);
            this.player2Picturebox.TabIndex = 1;
            this.player2Picturebox.TabStop = false;
            // 
            // player1PictureBox
            // 
            this.player1PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.player1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player1PictureBox.Image")));
            this.player1PictureBox.Location = new System.Drawing.Point(727, 368);
            this.player1PictureBox.Name = "player1PictureBox";
            this.player1PictureBox.Size = new System.Drawing.Size(40, 46);
            this.player1PictureBox.TabIndex = 0;
            this.player1PictureBox.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ballOvalShape});
            this.shapeContainer1.Size = new System.Drawing.Size(980, 417);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // ballOvalShape
            // 
            this.ballOvalShape.BackColor = System.Drawing.Color.Transparent;
            this.ballOvalShape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ballOvalShape.BackgroundImage")));
            this.ballOvalShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ballOvalShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ballOvalShape.Location = new System.Drawing.Point(433, 293);
            this.ballOvalShape.Name = "ballOvalShape";
            this.ballOvalShape.Size = new System.Drawing.Size(65, 60);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // blueWinsLbl
            // 
            this.blueWinsLbl.AutoSize = true;
            this.blueWinsLbl.Location = new System.Drawing.Point(246, 96);
            this.blueWinsLbl.Name = "blueWinsLbl";
            this.blueWinsLbl.Size = new System.Drawing.Size(58, 13);
            this.blueWinsLbl.TabIndex = 15;
            this.blueWinsLbl.Text = "Blue Wins!";
            // 
            // redWinsLbl
            // 
            this.redWinsLbl.AutoSize = true;
            this.redWinsLbl.Location = new System.Drawing.Point(684, 96);
            this.redWinsLbl.Name = "redWinsLbl";
            this.redWinsLbl.Size = new System.Drawing.Size(57, 13);
            this.redWinsLbl.TabIndex = 16;
            this.redWinsLbl.Text = "Red Wins!";
            // 
            // ArenaSoccer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 417);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArenaSoccer";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeypressActions);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyReleaseActions);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceiling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallForGoal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallForGoal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player1PictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player2Picturebox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ballOvalShape;
        private System.Windows.Forms.PictureBox goal1;
        private System.Windows.Forms.PictureBox goal2;
        private System.Windows.Forms.PictureBox wallForGoal1;
        private System.Windows.Forms.PictureBox wallForGoal2;
        private System.Windows.Forms.Label player1ScoreLbl;
        private System.Windows.Forms.Label player2ScoreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ceiling;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label redWinsLbl;
        private System.Windows.Forms.Label blueWinsLbl;
    }
}

