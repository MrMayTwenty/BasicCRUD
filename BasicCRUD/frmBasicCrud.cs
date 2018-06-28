using BasicCRUD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCRUD
{
    public partial class FrmBasicCrud : Form
    {
        DataAccess dao = new DataAccess();
        DataTable dtContactType = new DataTable();


        public FrmBasicCrud()
        {
            InitializeComponent();
            ResetAll();
            LoadContact();
        }

        private void ResetAll()
        {
            flwContacts.Controls.Clear();
            flwNumbers.Controls.Clear();
            flwAddress.Controls.Clear();
        }

        private void DataGridReset(DataGridView dg) {
            dg.Rows.Clear();
            dg.Refresh();
        }

        private void dgContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {
                //string conID = dgContact["dcContactID", e.RowIndex].Value.ToString();
                //LoadContactDetail(conID);
            }
        }


        private void LoadContact()
        {
            DataTable dt = dao.GetContact();
            foreach (DataRow dr in dt.Rows) {
                CtrlContactName ctrlContact = new CtrlContactName();
                ctrlContact.ID = Int64.Parse(dr["ID"].ToString());
                ctrlContact.SurName = dr["LastName"].ToString();
                ctrlContact.GivenName = dr["FirstName"].ToString() + " " + dr["MiddleName"].ToString();
                ctrlContact.Click += CtrlContact_Click;
                flwContacts.Controls.Add(ctrlContact);
            }
        }

        private void CtrlContact_Click(object sender, EventArgs e)
        {
            CtrlContactName ctrl = (CtrlContactName)sender;
            LoadContactDetail(ctrl.ID);
        }

        private void LoadContactDetail(Int64 ID)
        {

        }
    }
}
