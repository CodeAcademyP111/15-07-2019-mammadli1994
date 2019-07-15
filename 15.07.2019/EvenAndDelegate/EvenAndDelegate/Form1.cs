using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenAndDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += delegate (object s, EventArgs e)
              {
                  button1.Visible = false;
              };
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
