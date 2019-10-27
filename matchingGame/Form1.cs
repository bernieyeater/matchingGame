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
    }
}
