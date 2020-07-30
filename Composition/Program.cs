using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.com.mangSystem;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            University un = new University();
            /* un.Init_Chem("Chemistry", "Aslam", 500);

             un.Init_Comp("CS and IT", "Saad", 200);
             */

            un.AddDepartment("Chemistry","Zain",Dep.chem,700);
            un.AddDepartment("CS and IT", "Saad", Dep.comp, 450);

            foreach (var item in un.departments)
            {
                if(item is ChemDep)
                {
                    //Cast
                    ChemDep chem = (ChemDep)item;
                    Console.WriteLine("Department Name : {0} Director : {1}, Student Number{2}",chem.Name,chem.Director,chem.NumberofStudents);

                }
                else if (item is CompDep)
                {
                    //Cast
                    CompDep comp = (CompDep)item;
                    Console.WriteLine("Department Name : {0} Director : {1}, Student Number{2}", comp.Name, comp.Director, comp.Numberofcomp);

                }
            }

            Console.ReadLine();
        }
    }
}
