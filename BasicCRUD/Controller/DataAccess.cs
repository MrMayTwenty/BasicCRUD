using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD.Controller
{
    public class DataAccess
    {
        DatabaseController DBController;
        public DataAccess() {
            DBController = new DatabaseController();
        }

        /// <summary>
        /// Get All Contacts
        /// </summary>
        /// <returns></returns>
        public DataTable GetContact() {
            string sql = string.Format("SELECT * FROM DBO.ContactName");
            return DBController.GetTable(sql);
        } 
    }
}
