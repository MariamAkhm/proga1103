
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proga1103
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
            
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void save_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "name|*.txt*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.FileName);
                sw.WriteLine(surname2.Text);
                sw.WriteLine(name2.Text);
                sw.WriteLine(diagnosis.Text);
                sw.WriteLine(data.Text);
                data.Clear();
                diagnosis.Clear();
                name2.Clear();
                surname2.Clear();
                sw.Close();
            }

        }
    }
}
