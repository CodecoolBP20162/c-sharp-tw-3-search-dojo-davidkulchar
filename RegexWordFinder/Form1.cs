using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexWordFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFind.Text = "";
            string text = tbText.Text;
            string pat = @tBSearch.Text;

            Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            foreach (Match m in Regex.Matches(text, pat))
                tbFind.Text += m.Value + ", " ;
        }
    }
}
