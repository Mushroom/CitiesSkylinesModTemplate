using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitiesSkylinesModWizard
{
    public partial class BasicInfoForm : Form
    {
        public string Path, Name, Description;

        public BasicInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog(this);
            textBox3.Text = this.Path = fbd.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Description = textBox2.Text;
            this.Close();
        }
    }
}
