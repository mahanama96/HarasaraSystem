﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarasaraSystem.SubInterface.Production
{
    class Finishing : Manufacturing
    {
        private String pid;
        private String oid;
        private int queNum;
        Boolean progress;
        public Finishing(String pid,String oid,int queNum)
        {
            this.pid = pid;
            this.oid = oid;
            this.queNum = queNum;

        }
        
        public void updateProgress()
        {
           
            DBAccess db = new DBAccess();

            db.Update("UPDATE `splittedorder` SET `finish`= '" + 1 + "' WHERE `productID`= '" + pid + "' AND `orderID`= '" + oid + "' AND `queNo`= '" + queNum + "' ");
        }
    }
}
