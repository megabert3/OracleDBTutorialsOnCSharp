using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OracleDBTutorialsOnCSharp.modelTable {

    class Employees {

        [Key]
        public int Employee_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public string Hire_Date { get; set; }
        public string Job_id { get; set; }
        public int Salary { get; set; }
        public int Commission_PCT { get; set; }
        public int Manager_id { get; set; }
        public int Department_id { get; set; }
    }
}
