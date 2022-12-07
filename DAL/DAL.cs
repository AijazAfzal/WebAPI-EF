using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class emp_DAL
    {
        firstwebapiEntities1 objent = new firstwebapiEntities1();
        public List<emp_Common> getemp()
        {
            var li = objent.tbl_emp.Select(x => new emp_Common { empid = x.empid, empname = x.empname, empsal = x.empsal }).ToList();
            return li;
        }
        public int addemp(emp_Common empobj)
        {
            tbl_emp obj=new tbl_emp();
            obj.empid = empobj.empid;
            obj.empname = empobj.empname;
            obj.empsal = empobj.empsal;
            objent.tbl_emp.Add(obj);
            int res=objent.SaveChanges();
            return res;

        }

        public int deleteemp(emp_Common eobj)
        {
            var obj = objent.tbl_emp.Where(x => x.empid == eobj.empid).FirstOrDefault();
            objent.tbl_emp.Remove(obj);
            int res = objent.SaveChanges();
            return res;
        }

        public int updateemp(emp_Common eobj)
        {
            tbl_emp obj = new tbl_emp();
            obj.empid=eobj.empid;
            obj.empname = eobj.empname;
            obj.empsal = eobj.empsal;
            int res = objent.SaveChanges();
            return res;
            
        }
      

    }
}
