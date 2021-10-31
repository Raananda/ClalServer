using System;

namespace ServerTemplateSlim.Infra.DTO
{
    public class TaskDTO
    {
        public int TaskNumber { get; set; }
        public string TaskName { get; set; }
        public int StatusID { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentID { get; set; }
        public DateTime DueDate { get; set; }
    }
}
