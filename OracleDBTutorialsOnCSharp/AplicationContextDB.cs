using Microsoft.EntityFrameworkCore;
using OracleDBTutorialsOnCSharp.modelTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace OracleDBTutorialsOnCSharp {
    class AplicationContextDB : DbContext{

        public DbSet<Employees> Employeeses { get; set; }

        public AplicationContextDB() {
            Console.WriteLine(Database.EnsureCreated());
        }

        /// <summary>
        /// https://docs.oracle.com/en/database/oracle/oracle-data-access-components/19.3/odpnt/EFCoreAPI.html#GUID-2B7E9424-12C7-40AA-9429-6FD00C0027F4
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=xe)));User Id=hr;Password=hr;");
        }
    }
}
