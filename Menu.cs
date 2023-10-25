using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AnythingIsBetterThanCisco
{
    public partial class Menu : Form
    {
        private CheckBox[] moduleGroup1_3;

        public Menu()
        {
            InitializeComponent();

            moduleGroup1_3 = new CheckBox[] { moduCheck1, moduCheck2, moduCheck3 };

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

        /// <summary>
        /// Checks or unchecks all checkboxes of a group to match the parent
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="group"></param>
        private void ToggleModuleGroup(CheckBox parent, CheckBox[] group)
        {
            foreach (CheckBox checkbox in group)
                checkbox.Checked = parent.Checked;
        }

        /// <summary>
        /// Checks or unchecks the parent of a group to match the average
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="group"></param>
        private void ToggleModuleParent(CheckBox parent, CheckBox[] group)
        {
            int index = 1;
            do
            {
                parent.CheckState = group[index].Checked == group[0].Checked ?  // is this checkbox in the same state as the first?
                                    group[0].CheckState : CheckState.Indeterminate;  // copy state if yes, indeterminate if no
                index++;
            } while (parent.CheckState != CheckState.Indeterminate && index < group.Length);
        }

        private void moduCheck1_3_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduCheck1_3, moduleGroup1_3);
        private void moduCheck1_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduCheck1_3, moduleGroup1_3);
        private void moduCheck2_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduCheck1_3, moduleGroup1_3);
        private void moduCheck3_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduCheck1_3, moduleGroup1_3);
    }
}
