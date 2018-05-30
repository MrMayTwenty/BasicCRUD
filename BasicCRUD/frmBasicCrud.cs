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
            DataGridReset(dgContact);
        }

        private void DataGridReset(DataGridView dg) {
            dg.Rows.Clear();
            dg.Refresh();
        }

        private void dgContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) {
                string conID = dgContact["dcContactID", e.RowIndex].Value.ToString();
                LoadContactDetail(conID);
            }
        }


        private void LoadContact()
        {
            DataTable dt = dao.GetContact();
            int count = 0;
            foreach (DataRow dr in dt.Rows) {
                dgContact.Rows.Add();
                dgContact["dcContactID", count].Value = dr["ID"].ToString();
                dgContact["dcContactFirstName", count].Value = dr["FirstName"].ToString();
                dgContact["dcContactMiddleName", count].Value = dr["MiddleName"].ToString();
                dgContact["dcContactLastName", count].Value = dr["LastName"].ToString();
                count++;
            }
        }

        private void LoadContactDetail(string ID)
        {

        }
    }
}
