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
        private ModuleGroup moduleGroup4_7;
        private ModuleGroup moduleGroup8_10;
        private ModuleGroup moduleGroup11_13;
        private ModuleGroup moduleGroup14_15;
        private ModuleGroup moduleGroup16_17;

        public Menu()
        {
            InitializeComponent();

            moduleGroup1_3 = new ModuleGroup(moduCheck1_3, new CheckBox[] { moduCheck1, moduCheck2, moduCheck3 });
            moduleGroup4_7 = new ModuleGroup(moduCheck4_7, new CheckBox[] { moduCheck4, moduCheck5, moduCheck6, moduCheck7 });
            moduleGroup8_10 = new ModuleGroup(moduCheck8_10, new CheckBox[] { moduCheck8, moduCheck9, moduCheck10 });
            moduleGroup11_13 = new ModuleGroup(moduCheck11_13, new CheckBox[] { moduCheck11, moduCheck12, moduCheck13 });
            moduleGroup14_15 = new ModuleGroup(moduCheck14_15, new CheckBox[] { moduCheck14, moduCheck15 });
            moduleGroup16_17 = new ModuleGroup(moduCheck16_17, new CheckBox[] { moduCheck16, moduCheck17 });
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
