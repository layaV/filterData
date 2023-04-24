using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum JobRole
    {
        Developer,
        SrDeveloper,
        Architect,
        Manager
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public JobRole JobRole { get; set; }
        public DateTime DateJoined { get; set; }
        public string City { get; set; }
        public bool RemoteWorking { get; set; }
    }

}
