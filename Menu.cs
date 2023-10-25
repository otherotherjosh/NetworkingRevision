using System;
using System.Collections.Generic;
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

        private Dictionary<CheckBox, CheckBox[]> netacadModules;
        private Dictionary<CheckBox, CheckBox[]> sbaModules;
        private Dictionary<CheckBox, Dictionary<CheckBox, CheckBox[]>> modules;

        public Menu()
        {
            InitializeComponent();

            moduleGroup1_3 = new ModuleGroup(netacadModules1_3, new CheckBox[] { netacadModule1, netacadModule2, netacadModule3 });
            moduleGroup4_7 = new ModuleGroup(netacadModules4_7, new CheckBox[] { moduCheck4, moduCheck5, moduCheck6, moduCheck7 });
            moduleGroup8_10 = new ModuleGroup(netacadModules8_10, new CheckBox[] { moduCheck8, moduCheck9, moduCheck10 });
            moduleGroup11_13 = new ModuleGroup(netacadModules11_13, new CheckBox[] { moduCheck11, moduCheck12, moduCheck13 });
            moduleGroup14_15 = new ModuleGroup(netacadModules14_15, new CheckBox[] { moduCheck14, moduCheck15 });
            moduleGroup16_17 = new ModuleGroup(netacadModules16_17, new CheckBox[] { moduCheck16, moduCheck17 });

            // dictionary instead of struct
            netacadModules = new Dictionary<CheckBox, CheckBox[]>();
            sbaModules = new Dictionary<CheckBox, CheckBox[]>();
            modules = new Dictionary<CheckBox, Dictionary<CheckBox, CheckBox[]>>();

            netacadModules.Add(netacadModules1_3, new CheckBox[] { netacadModule1, netacadModule2, netacadModule3 });
            netacadModules.Add(netacadModules4_7, new CheckBox[] { moduCheck4, moduCheck5, moduCheck6, moduCheck7 });
            netacadModules.Add(netacadModules8_10, new CheckBox[] { moduCheck8, moduCheck9, moduCheck10 });
            netacadModules.Add(netacadModules11_13, new CheckBox[] { moduCheck11, moduCheck12, moduCheck13 });
            netacadModules.Add(netacadModules14_15, new CheckBox[] { moduCheck14, moduCheck15 });
            netacadModules.Add(netacadModules16_17, new CheckBox[] { moduCheck16, moduCheck17 });
            modules.Add(netacadModulesAll, netacadModules);
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
                m.parent.CheckState = m.group[index].CheckState == m.group[0].CheckState ?  // is this checkbox in the same state as the first?
                                    m.group[0].CheckState : CheckState.Indeterminate;  // copy state if yes, indeterminate if no
                index++;
            } while (m.parent.CheckState != CheckState.Indeterminate && index < m.group.Length);
        }

        private void ToggleModuleParent(CheckBox parent)
        {
            
        }

        private void ToggleModuleGroup(CheckBox parent)
        {
            if (modules.Keys.Contains(parent))
            {
                foreach (CheckBox value in modules[parent].Keys)
                {
                    value.Checked = parent.Checked;
                    ToggleModuleGroup(value);
                }
                return;
            }
            foreach (CheckBox key in modules.Keys)
            {
                if (modules[key].Keys.Contains(parent))
                {
                    foreach (CheckBox value in modules[key][parent])
                    {
                        value.Checked = parent.Checked;
                    }
                    return;
                }
            }
        }

        private void moduCheck1_3_Click(object sender, EventArgs e)
        => ToggleModuleGroup(netacadModules1_3);
        private void moduCheck1_Click(object sender, EventArgs e)
        => ToggleModuleParent(netacadModules1_3);
        private void moduCheck2_Click(object sender, EventArgs e)
        => ToggleModuleParent(netacadModules1_3);
        private void moduCheck3_Click(object sender, EventArgs e)
        => ToggleModuleParent(netacadModules1_3);

        private void moduCheck4_7_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduleGroup4_7);
        private void moduCheck4_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup4_7);
        private void moduCheck5_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup4_7);
        private void moduCheck6_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup4_7);
        private void moduCheck7_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup4_7);

        private void moduCheck8_10_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduleGroup8_10);
        private void moduCheck8_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup8_10);
        private void moduCheck9_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup8_10);
        private void moduCheck10_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup8_10);

        private void moduCheck11_13_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduleGroup11_13);
        private void moduCheck11_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup11_13);
        private void moduCheck12_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup11_13);
        private void moduCheck13_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup11_13);

        private void moduCheck14_15_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduleGroup14_15);
        private void moduCheck14_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup14_15);
        private void moduCheck15_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup14_15);

        private void moduCheck16_17_Click(object sender, EventArgs e)
        => ToggleModuleGroup(moduleGroup16_17);
        private void moduCheck16_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup16_17);
        private void moduCheck17_Click(object sender, EventArgs e)
        => ToggleModuleParent(moduleGroup16_17);

        private void netacadModulesAll_Click(object sender, EventArgs e)
        => ToggleModuleGroup(netacadModulesAll);
    }
}
