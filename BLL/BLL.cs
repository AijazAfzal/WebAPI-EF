using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Common;
using DAL;

namespace BLL
{
    public class emp_BLL 
    {
        emp_DAL objdal = new emp_DAL();
        public List<emp_Common> getemp()
        {
            return objdal.getemp();
        }

        public int addemp(emp_Common empobj)
        {
            return objdal.addemp(empobj);
          

        }

        public int deleteemp(emp_Common eobj)
        {
            return objdal.deleteemp(eobj);
        }

        public int updateemp(emp_Common eobj)
        {
            return objdal.updateemp(eobj); 
        }



    }
}
