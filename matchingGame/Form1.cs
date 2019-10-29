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
        Random random;
        List<String> icons = new List<string>()
        { "a", "a", "b", "b","c","c","d","d",
            "e","e","f","f","g","g","h","h"};
        public Form1()
        {
            InitializeComponent();
        }

        private void assignIcons()
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                Label iconLabel = control as Label;
                    if(iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                }
            }
        }

        private void lbl00_Click(object sender, EventArgs e)
        {

        }
    }
}
