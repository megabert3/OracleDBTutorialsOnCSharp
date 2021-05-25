using OracleDBTutorialsOnCSharp.modelTable;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OracleDBTutorialsOnCSharp {
    class Program {
        static void Main(string[] args) {

            using (AplicationContextDB aplicationContextDB = new AplicationContextDB()) {
                aplicationContextDB.Add(new Employees());
                aplicationContextDB.SaveChanges();

                List<Employees> employeesList = aplicationContextDB.Employeeses.ToList();
            }
        }
    }
}
