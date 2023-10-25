using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AnythingIsBetterThanCisco
{
    public struct ModuleGroup
    {
        public CheckBox parent;
        public CheckBox[] group;

        public ModuleGroup(CheckBox parent, CheckBox[] group)
        {
            this.parent = parent;
            this.group = group;
        }
    }

    public partial class Menu : Form
    {
        private ModuleGroup moduleGroup1_3;

        public Menu()
        {
            InitializeComponent();

            moduleGroup1_3 = new ModuleGroup(moduCheck1_3, new CheckBox[] { moduCheck1, moduCheck2, moduCheck3 });
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
        private void ToggleModuleGroup(ModuleGroup m)
        {
            foreach (CheckBox checkbox in m.group)
                checkbox.Checked = m.parent.Checked;
        }

        /// <summary>
        /// Checks or unchecks the parent of a group to match the average
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="group"></param>
        private void ToggleModuleParent(ModuleGroup m)
        {
            int index = 1;
            do
            {
                m.parent.CheckState = m.group[index].Checked == m.group[0].Checked ?  // is this checkbox in the same state as the first?
                                    m.group[0].CheckState : CheckState.Indeterminate;  // copy state if yes, indeterminate if no
                index++;
            } while (m.parent.CheckState != CheckState.Indeterminate && index < m.group.Length);
        }

        private void moduCheck1_3_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduleGroup1_3);
        private void moduCheck1_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup1_3);
        private void moduCheck2_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup1_3);
        private void moduCheck3_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup1_3);
    }
}
