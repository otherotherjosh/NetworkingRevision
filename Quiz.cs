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
        Question[] questions;
        int questionIndex = 0;

        public Quiz()
        {
            InitializeComponent();
            questions = new Question[]
            {
                new Question("Which of the following is the name for all computers connected to a network that participate directly in network communication?\n"
                             + "- servers\n- intermediary devices\n- hosts\n- media",
                             "hosts",
                             Properties.Resources.q1, Properties.Resources.a1),
                new Question("When data is encoded as pulses of light, which media is being used to transmit the data?\n"
                             + "- wireless\n- fibre-optic cable\n- copper cable",
                             "fibre-optic cable",
                             Properties.Resources.q2, Properties.Resources.a2),
                new Question("Which two devices are intermediary devices? (Choose two)\n"
                             + "hosts\n- routers\n- servers\n- switches",
                             $"routers && switches",
                             Properties.Resources.q3, Properties.Resources.a3)
            };

            refresh();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            showAnswer = showAnswer ? false : true;
            toggleAnswer();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            questionIndex--;
            refresh();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            questionIndex++;
            refresh();
        }

        private void toggleAnswer()
        {
            answerButton.Text = showAnswer ? "hide answer" : "show answer";
            textboxA.Visible = showAnswer;
            answerPicture.Visible = showAnswer;
        }

        private void refresh()
        {
            showAnswer = false;
            toggleAnswer();
            prevButton.Enabled = questionIndex > 0;
            nextButton.Enabled = questionIndex < questions.Count() - 1;
            textboxQ.Text = questions[questionIndex].Q;
            textboxA.Text = questions[questionIndex].A;
            questionPicture.Image = questions[questionIndex].ImgQ;
            answerPicture.Image = questions[questionIndex].ImgA;
        }
    }
}
