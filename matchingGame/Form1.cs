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
        Label firstClicked = null;
        Label secondClicked = null;
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
                    int randomNumber = random.Next(0, icons.Count);
                    iconLabel.ForeColor = iconLabel.BackColor;
                    iconLabel.Text = icons[randomNumber];
                }
            }
        }


        private void label_click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                clickedLabel.ForeColor = Color.Black;
                //if (firstClicked == null)
                //{
                //    firstClicked = clickedLabel;
                //    firstClicked.ForeColor = Color.Black;
                 //   return;
               // }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
    }
}
