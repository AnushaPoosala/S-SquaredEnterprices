using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace S_SquaredEnterprices3.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public Role Role { get; set; }

        [Required]
        public byte EmployeeRoleId { get; set; }


        public string ManagerFirstName { get; set; }
        public string ManagerLasttName { get; set; }
        public int ManagerEmployeeId { get; set; }


    }
}