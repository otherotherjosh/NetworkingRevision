using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnythingIsBetterThanCisco
{
    public partial class Quiz : Form
    {
        Random rand = new Random();
        bool showAnswer;

        public Quiz(string question, string answer, Bitmap imgQ, Bitmap imgA)
        {
            InitializeComponent();

            showAnswer = false;
            label1.Text = question;
            label2.Text = answer;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            showAnswer = showAnswer ? false : true;
            if (showAnswer)
            {
                answerButton.Text = answerButton.Text.Replace("show", "hide");
                label2.Visible = true;
                answerPicture.Visible = true;
            }
            if (! showAnswer)
            {
                answerButton.Text = answerButton.Text.Replace("hide", "show");
                label2.Visible = false;
                answerPicture.Visible = false;
            }
        }
    }
}
