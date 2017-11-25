using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    class FinishProcess
    {
        String pid;
        String oid;
        int q;
        int num;
        int count = 0;

        DBAccess db=new DBAccess();
        DBAccess db1 = new DBAccess();
        DBAccess db2 = new DBAccess();
        DataTable dt = new DataTable();

        String query = "SELECT `productID`, `orderID`, `queNo` FROM `splittedorder` WHERE  `cutting`= '" + "1" + "'AND `painting`= '" + "1" + "'AND `drilling`= '" + "1" + "'AND `fitting`= '" + "1" + "'AND`finish`= '" + "1" + "'";

        public void checkTable()
        {
            
            dt = db.Select(query);
            foreach (DataRow row in dt.Rows)
            {
                count++;
                pid = row["productID"].ToString();
                oid = row["orderID"].ToString();
                q = Convert.ToInt32(row["queNo"].ToString());

                db1.Delete("DELETE FROM `splittedorder` WHERE `productID` = '" + pid + "' AND `orderID`= '" + oid + "' AND `queNo`= '" + q + "'");
                


            }
            db2.Insert("INSERT INTO `finishedorders`(`product`, `orderid`, `quantity`) VALUES ('" + pid + "','" + oid + "','" + q + "')");
            
        }
    
    }
}
