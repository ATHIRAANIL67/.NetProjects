//Entity Framework - Database First Approach
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExercisesDBEntities e1= new ExercisesDBEntities();
            foreach(var item in e1.DEPARTMENTS)
            {
                Console.WriteLine(item.department_name);
            }

            /*using (var context = new ExercisesDBEntities())
            {
                var emp1 = new EMPLOYEE()
                {
                    employee_id = 109,
                    first_name = "Bill",
                    last_name = "Gates",
                    email = "billgates@gmail.com",
                    phone_number = 2567898,
                    salary = 24000,
                    commission_pct = 11
                };
                context.EMPLOYEES.Add(emp1);
                context.SaveChanges();
            }*/
            ExercisesDBEntities e2 = new ExercisesDBEntities();
            foreach (var item in e2.EMPLOYEES){
                Console.Write(item.employee_id+" "+item.first_name+" "+item.last_name+" "+item.salary);
            }

            /*using(var context=new ExercisesDBEntities())
            {
                var emp = context.EMPLOYEES.Where(s => s.employee_id == 109).FirstOrDefault<EMPLOYEE>();
                emp.first_name = "Steve";
                emp.last_name = "Jobs";
                emp.email = "stevejobs@gmail.com";
                context.SaveChanges();
            }*/

            using (var context = new ExercisesDBEntities())
            {
                var emp = context.EMPLOYEES.Where(e => e.employee_id == 110).FirstOrDefault<EMPLOYEE>();
                context.EMPLOYEES.Remove(emp);

                context.SaveChanges();
            }
        }
    }
}
