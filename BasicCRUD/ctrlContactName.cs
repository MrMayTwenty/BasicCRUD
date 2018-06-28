using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCRUD
{
    public partial class CtrlContactName : UserControl
    {


        public Int64 ID {
            get;set;
        }

        public string SurName{
            get
            {
                return lblSurname.Text;
            }
            set
            {
                lblSurname.Text = value;
            }
        }

        public string GivenName
        {
            get
            {
                return lblGivenName.Text;
            }
            set
            {
                lblGivenName.Text = value;
            }
        }

        public CtrlContactName()
        {
            InitializeComponent();
            //lblGivenName.Enabled = false;
            //lblSurname.Enabled = false;
            //lblGivenName.ForeColor = Color.Black;
            //lblSurname.ForeColor = Color.Black;
        }

        private void CtrlContactName_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void CtrlContactName_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void CtrlContactName_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
        }

        private void CtrlContactName_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
