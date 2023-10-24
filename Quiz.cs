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
    public partial class Quiz : Form
    {
        Random rand = new Random();

        public Quiz()
        {
            InitializeComponent();

            if (rand.Next(0, 2) == 0)
            {
                quizPicture.Image = Properties.Resources.cum;
            }
            else
            {
                quizPicture.Image = Properties.Resources.gid;
            }
        }
    }
}
