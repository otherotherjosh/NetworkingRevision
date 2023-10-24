using System;
using System.Threading;
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
            Quiz quiz = new Quiz();
            quiz.StartPosition = FormStartPosition.Manual;
            quiz.Location = this.Location;
            quiz.ShowDialog();
            this.Location = quiz.Location;
            this.Show();
        }

        //private void moduCheck1_3_CheckedChanged(object sender, EventArgs e)
        //=> ToggleModuleGroup(moduCheck1_3, new CheckBox[] {moduCheck1, moduCheck2, moduCheck3});

        /// <summary>
        /// Checks or unchecks all checkboxes of a group to match the parent
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="group"></param>
        private void ToggleModuleGroup(CheckBox parent, CheckBox[] group)
        {
            foreach (CheckBox checkbox in group)
            {
                checkbox.Checked = parent.Checked;
            }
        }

        /// <summary>
        /// Checks or unchecks the parent of a group to match the average
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="group"></param>
        private void ToggleModuleParent(CheckBox parent, CheckBox[] group)
        {

        }
    }
}
