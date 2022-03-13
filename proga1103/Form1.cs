using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proga1103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Information_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void addNewStudent_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }
        private void NameSurname_TextChanged(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.surname2.Text= "name|*.txt*";
        }
    }
}
