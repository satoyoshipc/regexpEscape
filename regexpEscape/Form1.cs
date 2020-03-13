using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace regexpEscape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //文字列中の記号のうち正規表現要素として使われるものをエスケープする
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(Regex.Escape(textBox1.Text));
            textBox2.Text = Regex.Escape(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
