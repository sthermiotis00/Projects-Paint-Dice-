﻿namespace ergasia
{
    partial class GameLevel1
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
            this.start_button1 = new System.Windows.Forms.Button();
            this.stop_button2 = new System.Windows.Forms.Button();
            this.exit_button3 = new System.Windows.Forms.Button();
            this.Time_label1 = new System.Windows.Forms.Label();
            this.touches_label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.score_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button1
            // 
            this.start_button1.Location = new System.Drawing.Point(12, 12);
            this.start_button1.Name = "start_button1";
            this.start_button1.Size = new System.Drawing.Size(75, 33);
            this.start_button1.TabIndex = 0;
            this.start_button1.Text = "Start/Stop";
            this.start_button1.UseVisualStyleBackColor = true;
            this.start_button1.Click += new System.EventHandler(this.start_button1_Click);
            // 
            // stop_button2
            // 
            this.stop_button2.Location = new System.Drawing.Point(12, 51);
            this.stop_button2.Name = "stop_button2";
            this.stop_button2.Size = new System.Drawing.Size(75, 33);
            this.stop_button2.TabIndex = 1;
            this.stop_button2.Text = "Finish";
            this.stop_button2.UseVisualStyleBackColor = true;
            this.stop_button2.Click += new System.EventHandler(this.stop_button2_Click);
            // 
            // exit_button3
            // 
            this.exit_button3.Location = new System.Drawing.Point(12, 90);
            this.exit_button3.Name = "exit_button3";
            this.exit_button3.Size = new System.Drawing.Size(75, 33);
            this.exit_button3.TabIndex = 2;
            this.exit_button3.Text = "Exit";
            this.exit_button3.UseVisualStyleBackColor = true;
            this.exit_button3.Click += new System.EventHandler(this.exit_button3_Click);
            // 
            // Time_label1
            // 
            this.Time_label1.AutoSize = true;
            this.Time_label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label1.Location = new System.Drawing.Point(731, 18);
            this.Time_label1.Name = "Time_label1";
            this.Time_label1.Size = new System.Drawing.Size(57, 19);
            this.Time_label1.TabIndex = 3;
            this.Time_label1.Text = "Time";
            // 
            // touches_label1
            // 
            this.touches_label1.AutoSize = true;
            this.touches_label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touches_label1.Location = new System.Drawing.Point(12, 412);
            this.touches_label1.Name = "touches_label1";
            this.touches_label1.Size = new System.Drawing.Size(93, 19);
            this.touches_label1.TabIndex = 4;
            this.touches_label1.Text = "Touches";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(316, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 124);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // score_label1
            // 
            this.score_label1.AutoSize = true;
            this.score_label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label1.Location = new System.Drawing.Point(12, 375);
            this.score_label1.Name = "score_label1";
            this.score_label1.Size = new System.Drawing.Size(69, 19);
            this.score_label1.TabIndex = 6;
            this.score_label1.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Level 1!";
            // 
            // GameLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score_label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.touches_label1);
            this.Controls.Add(this.Time_label1);
            this.Controls.Add(this.exit_button3);
            this.Controls.Add(this.stop_button2);
            this.Controls.Add(this.start_button1);
            this.Name = "GameLevel1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button1;
        private System.Windows.Forms.Button stop_button2;
        private System.Windows.Forms.Button exit_button3;
        private System.Windows.Forms.Label Time_label1;
        private System.Windows.Forms.Label touches_label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label score_label1;
        private System.Windows.Forms.Label label1;
    }
}