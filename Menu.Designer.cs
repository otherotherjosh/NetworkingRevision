﻿namespace AnythingIsBetterThanCisco
{
    partial class Menu
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
            this.startButton = new System.Windows.Forms.Button();
            this.moduCheck1_3 = new System.Windows.Forms.CheckBox();
            this.moduCheck1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(600, 592);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 49);
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Text = "begin";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // moduCheck1_3
            // 
            this.moduCheck1_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.moduCheck1_3.AutoSize = true;
            this.moduCheck1_3.BackColor = System.Drawing.SystemColors.Control;
            this.moduCheck1_3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.moduCheck1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduCheck1_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moduCheck1_3.Location = new System.Drawing.Point(608, 218);
            this.moduCheck1_3.Name = "moduCheck1_3";
            this.moduCheck1_3.Size = new System.Drawing.Size(101, 26);
            this.moduCheck1_3.TabIndex = 2;
            this.moduCheck1_3.TabStop = false;
            this.moduCheck1_3.Text = "Modules 1-3";
            this.moduCheck1_3.UseVisualStyleBackColor = false;
            this.moduCheck1_3.CheckedChanged += new System.EventHandler(this.moduCheck1_3_CheckedChanged);
            // 
            // moduCheck1
            // 
            this.moduCheck1.AutoSize = true;
            this.moduCheck1.Location = new System.Drawing.Point(616, 250);
            this.moduCheck1.Name = "moduCheck1";
            this.moduCheck1.Size = new System.Drawing.Size(84, 20);
            this.moduCheck1.TabIndex = 3;
            this.moduCheck1.Text = "Module 1";
            this.moduCheck1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(616, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Module 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(616, 302);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 20);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Module 3";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 654);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.moduCheck1);
            this.Controls.Add(this.moduCheck1_3);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Networking Revision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox moduCheck1_3;
        private System.Windows.Forms.CheckBox moduCheck1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}