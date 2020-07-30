using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.com.mangSystem
{
    enum Dep
    {
        comp,
        chem
    }
    class University
    {
        public List<Department> departments  = new List<Department>();

        public void AddDepartment(string nam, string dnam,Dep dep,int no)
        {
            if (dep == Dep.chem)
            {
                ChemDep obj = new ChemDep();

                obj.Name = nam;
                obj.Director = dnam;
                obj.NumberofStudents = no;
                //We make list of base class but we add child class in list, we can do it.
                departments.Add(obj);

            }
            else if (dep==Dep.comp)
            {
                CompDep obj = new CompDep();

                obj.Name = nam;
                obj.Director = dnam;
                obj.Numberofcomp = no;

                departments.Add(obj);

            }
        }
        /*
       public void Init_Chem(string n,string dn,int no)
        {
            ChemDep obj = new ChemDep();

            obj.Name = n;
            obj.Director = dn;
            obj.NumberofStudents = no;

            //Console.WriteLine(obj.Name);

        }
       public void Init_Comp(string n, string dn, int no)
        {
            CompDep obj = new CompDep();

            obj.Name = n;
            obj.Director = dn;
            obj.Numberofcomp = no;

        }  */
    }
}
