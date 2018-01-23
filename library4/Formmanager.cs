using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace library4
{
    public partial class Formmanager : Form
    {
        Form1 f1;
        public Formmanager(Form1 q)
        {
            InitializeComponent();
            f1 = q;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void Formmanager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Formmanager_Load(object sender, EventArgs e)
        {
            
        }
    }
}
