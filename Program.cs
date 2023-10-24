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
        public static Question[] questions;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
