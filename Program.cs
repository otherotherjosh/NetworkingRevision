using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnythingIsBetterThanCisco
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }

    public class Question
    {
        private string q;
        private string a;
        private Bitmap imgQ;
        private Bitmap imgA;

        public string Q { get => q; set => q = value; }
        public string A { get => a; set => a = value; }
        public Bitmap ImgQ { get => imgQ; set => imgQ = value; }
        public Bitmap ImgA { get => imgA; set => imgA = value; }

        public Question(string q, string a, Bitmap imgQ = null, Bitmap imgA = null)
        {
            Q = q;
            A = a;
            ImgQ = imgQ;
            ImgA = imgA;
        }
    }
}
