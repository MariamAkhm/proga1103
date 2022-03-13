using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace proga1103
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "name|*.txt*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(open.FileName);
                    sr.ReadToEnd();
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                }
            }
        }

        private void history_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void information_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
