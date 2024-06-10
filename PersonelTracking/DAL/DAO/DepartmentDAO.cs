using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public   class DepartmentDAO:EmployeeContext

    {
       
        public static void AddDepartment(DEPARTMENT department)
        {
            try
            {
                db.DEPARTMENTs.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
