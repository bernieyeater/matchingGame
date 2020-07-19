using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchingGame
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        List<String> icons = new List<string>()

        { "!", "!", "N", "N",",",",","k","k",
            "b","b","v","v","w","w","z","z"};

        public Form1()
        {
            InitializeComponent();
            assignIcons();
        }

        private void assignIcons()
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                Label iconLabel = control as Label;
                    if(iconLabel != null)
                {
                    int randomNumber = random.Next(0, 15);
                    iconLabel.Text = icons[randomNumber];
                }
            }
        }



        private void lbl00_Click(object sender, EventArgs e)
        {

        }

        private void lbl02_Click(object sender, EventArgs e)
        {

        }
    }
}
