using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnythingIsBetterThanCisco
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            startButton.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Question question in Program.questions)
            {
                Quiz quiz = new Quiz(question.Q, question.A, question.ImgQ, question.ImgA);
                quiz.StartPosition = FormStartPosition.Manual;
                quiz.Location = this.Location;
                quiz.ShowDialog();
                this.Location = quiz.Location;
            }
            this.Show();
        }
    }
}
