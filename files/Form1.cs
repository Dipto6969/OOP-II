using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
    public partial class Form1 : Form
    {
        List<readOnly>readOnlies = new List<readOnly>();
        List<editable>editable = new List<editable>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Summary_Click(object sender, EventArgs e)
        {

        }

        private void AddFile_Click(object sender, EventArgs e)
        {

        }

        private void fileNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveFile_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (var item in readOnlies)
            {
                
            }
        }
    }
}
