using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCustomer
{
    public class CCustomer
    {
        private string strId="";
        public string id
        {
            get { 
                return strId; 
            }
            set { 
                strId = value; 
            }
        }
        private string strName = "";

        public string name
        {
            get { return strName; }
            set { strName = value; }
        }
        private string strPhone = "";

        public string phone
        {
            get { return strPhone; }
            set { strPhone = value; }
        }
        private string strEmail = "";

        public string email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        private string strAddress = "";

        public string address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }


    }
}
