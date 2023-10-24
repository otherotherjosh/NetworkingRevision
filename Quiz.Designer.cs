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
            this.questionPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answerPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPicture
            // 
            this.questionPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.questionPicture.ErrorImage = null;
            this.questionPicture.Image = global::AnythingIsBetterThanCisco.Properties.Resources.gid;
            this.questionPicture.InitialImage = null;
            this.questionPicture.Location = new System.Drawing.Point(589, 12);
            this.questionPicture.Name = "questionPicture";
            this.questionPicture.Size = new System.Drawing.Size(400, 220);
            this.questionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionPicture.TabIndex = 0;
            this.questionPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 124);
            this.label2.TabIndex = 3;
            this.label2.Text = "answer";
            this.label2.Visible = false;
            // 
            // answerPicture
            // 
            this.answerPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.answerPicture.ErrorImage = null;
            this.answerPicture.Image = global::AnythingIsBetterThanCisco.Properties.Resources.cum;
            this.answerPicture.InitialImage = null;
            this.answerPicture.Location = new System.Drawing.Point(589, 238);
            this.answerPicture.Name = "answerPicture";
            this.answerPicture.Size = new System.Drawing.Size(400, 220);
            this.answerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerPicture.TabIndex = 4;
            this.answerPicture.TabStop = false;
            this.answerPicture.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 531);
            this.Controls.Add(this.answerPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox questionPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox answerPicture;
    }
}