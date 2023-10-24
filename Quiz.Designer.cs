namespace AnythingIsBetterThanCisco
{
    partial class Quiz
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
            this.quizPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quizPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // quizPicture
            // 
            this.quizPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.quizPicture.ErrorImage = null;
            this.quizPicture.Image = global::AnythingIsBetterThanCisco.Properties.Resources.gid;
            this.quizPicture.InitialImage = null;
            this.quizPicture.Location = new System.Drawing.Point(589, 12);
            this.quizPicture.Name = "quizPicture";
            this.quizPicture.Size = new System.Drawing.Size(400, 250);
            this.quizPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quizPicture.TabIndex = 0;
            this.quizPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 124);
            this.label1.TabIndex = 1;
            this.label1.Text = "question";
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.Location = new System.Drawing.Point(450, 450);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(100, 40);
            this.answerButton.TabIndex = 2;
            this.answerButton.TabStop = false;
            this.answerButton.Text = "show answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 531);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quizPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.quizPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox quizPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answerButton;
    }
}