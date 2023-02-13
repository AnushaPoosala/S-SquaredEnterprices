using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace S_SquaredEnterprices3.Models
{
    public class Role
    {
        [Key]
        public byte EmployeeRoleId { get; set; }
        public string RoleName { get; set; }
    }
}