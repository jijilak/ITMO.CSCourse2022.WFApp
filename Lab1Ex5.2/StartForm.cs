using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Ex5._2
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    StartForm f2 = new StartForm();
        //    f2.ShowDialog();
        //}

        //private void cForm1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        private void OpenForm1_Click(object sender, EventArgs e)
        {
            ParentForm f2 = new ParentForm();
            f2.ShowDialog();
        }
        private void CloseForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
