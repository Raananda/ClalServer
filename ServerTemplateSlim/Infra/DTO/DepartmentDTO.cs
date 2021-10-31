using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerTemplateSlim.Infra.DTO
{
    public class DepartmentDTO
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int ParentID { get; set; }
    }
}

