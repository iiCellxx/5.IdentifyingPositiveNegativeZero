﻿namespace _5.IdentifyingPositiveNegativeZero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            enterB = new Button();
            numberTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // enterB
            // 
            enterB.BackColor = SystemColors.ButtonHighlight;
            enterB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            enterB.Location = new Point(197, 346);
            enterB.Name = "enterB";
            enterB.Size = new Size(120, 63);
            enterB.TabIndex = 1;
            enterB.Text = "Enter";
            enterB.UseVisualStyleBackColor = false;
            enterB.Click += enterB_Click;
            // 
            // numberTB
            // 
            numberTB.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            numberTB.Location = new Point(164, 165);
            numberTB.Name = "numberTB";
            numberTB.Size = new Size(181, 135);
            numberTB.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 502);
            Controls.Add(numberTB);
            Controls.Add(enterB);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button enterB;
        private TextBox numberTB;
    }
}