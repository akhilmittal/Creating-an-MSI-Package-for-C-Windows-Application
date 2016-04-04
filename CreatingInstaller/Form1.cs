using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreatingInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var sampleText= File.ReadAllText(Application.StartupPath + "\\Input\\Sample.txt");
           MessageBox.Show("Text : " + textBox1.Text);
           MessageBox.Show("Text from File: " + sampleText);
        }
    }
}
