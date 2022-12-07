using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common; 


namespace WebAPI_EF.Controllers
{
    public class EmpController : Controller
    {
        emp_BLL objbal = new emp_BLL();
        [Route("WebAPI_EF/Emp/getemp")]
        [HttpGet]
        public void getemp(emp_Common obj) 
        {
             var b = objbal.getemp(); 
            

            
        }
        [Route("WebAPI_EF/Emp/addemp")]
        [HttpPost]
        public int addemp(emp_Common empobj)
        {
            int c = objbal.addemp(empobj); 
            return c;


        }
        [Route("WebAPI_EF/Emp/deleteemp")]
        [HttpDelete]

        public int deleteemp(emp_Common eobj)
        {
            int d = objbal.deleteemp(eobj);
            return d;
           
        }

        [Route("WebAPI_EF/Emp/updateemp")]
        [HttpPut]

        public int updateemp(emp_Common eobj)
        {
            int e=objbal.updateemp(eobj);
            return e; 
            

        }

    }
}