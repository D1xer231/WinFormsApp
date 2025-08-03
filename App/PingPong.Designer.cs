namespace App
{
    partial class PingPong
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
            this.Platform = new System.Windows.Forms.PictureBox();
            this.GameBall = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();
            this.ResultLB = new System.Windows.Forms.Label();
            this.LoseLabel = new System.Windows.Forms.Label();
            this.Rlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).BeginInit();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Platform.Location = new System.Drawing.Point(281, 431);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(198, 16);
            this.Platform.TabIndex = 0;
            this.Platform.TabStop = false;
            // 
            // GameBall
            // 
            this.GameBall.BackColor = System.Drawing.Color.Aquamarine;
            this.GameBall.Location = new System.Drawing.Point(223, 210);
            this.GameBall.Name = "GameBall";
            this.GameBall.Size = new System.Drawing.Size(30, 30);
            this.GameBall.TabIndex = 1;
            this.GameBall.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.Rlabel);
            this.GamePanel.Controls.Add(this.Platform);
            this.GamePanel.Controls.Add(this.LoseLabel);
            this.GamePanel.Controls.Add(this.ResultLB);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(800, 450);
            this.GamePanel.TabIndex = 2;
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLB.ForeColor = System.Drawing.Color.White;
            this.ResultLB.Location = new System.Drawing.Point(12, 9);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(168, 36);
            this.ResultLB.TabIndex = 0;
            this.ResultLB.Text = "Score: 0";
            // 
            // LoseLabel
            // 
            this.LoseLabel.AutoSize = true;
            this.LoseLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoseLabel.Location = new System.Drawing.Point(296, 192);
            this.LoseLabel.Name = "LoseLabel";
            this.LoseLabel.Size = new System.Drawing.Size(202, 57);
            this.LoseLabel.TabIndex = 1;
            this.LoseLabel.Text = "YOU LOST";
            this.LoseLabel.Visible = false;
            // 
            // Rlabel
            // 
            this.Rlabel.AutoSize = true;
            this.Rlabel.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rlabel.Location = new System.Drawing.Point(285, 249);
            this.Rlabel.Name = "Rlabel";
            this.Rlabel.Size = new System.Drawing.Size(229, 31);
            this.Rlabel.TabIndex = 2;
            this.Rlabel.Text = "PRESS R TO RESTART";
            this.Rlabel.Visible = false;
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameBall);
            this.Controls.Add(this.GamePanel);
            this.Name = "PingPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox GameBall;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label ResultLB;
        private System.Windows.Forms.Label LoseLabel;
        private System.Windows.Forms.Label Rlabel;
    }
}