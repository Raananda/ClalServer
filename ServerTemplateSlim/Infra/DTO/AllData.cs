using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerTemplateSlim.Infra.DTO
{
    public class AllData
    {
        public List<EmployeeDTO> Employees { get; set; }
        public List<DepartmentDTO> Departments { get; set; }
        public List<TaskDTO> Tasks { get; set; }
    }
}
