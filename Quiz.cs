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
                             "hosts"),
                new Question("When data is encoded as pulses of light, which media is being used to transmit the data?\n"
                             + "-wireless\n- fibre-optic cable\n- copper cable",
                             "fibre-optic cable"),
                new Question("Which two devices are intermediary devices? (Choose two)\n"
                             + "hosts\n- routers\n- servers\n- switches",
                             $"routers && switches")
            };

            showAnswer = false;
            label1.Text = "insert question here";
            label2.Text = "insert answer here";
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

        private void refresh()
        {
            prevButton.Enabled = questionIndex >= 0;
            nextButton.Enabled = questionIndex <= questions.Count();
        }
    }
}
