using Newtonsoft.Json;
using ServerTemplateSlim.Infra.DTO;
using ServerTemplateSlim.Infra.DTO.JsonLocalStorage;
using ServerTemplateSlim.Infra.Interfaces.BLL;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ServerTemplateSlim.BLL
{
    public class JsonLocalFileService : IJsonLocalFileService
    {
        public async Task<AllData> GetJsonData()
        {
            AllData Response = new AllData();

            Response.Employees = JsonConvert.DeserializeObject<List<EmployeeDTO>>(File.ReadAllText(@"C:\Users\troni\source\repos\ClalServer\ServerTemplateSlim\BLL\JsonLocalStorage\Employees.json"));
            Response.Departments = JsonConvert.DeserializeObject<List<DepartmentDTO>>(File.ReadAllText(@"C:\Users\troni\source\repos\ClalServer\ServerTemplateSlim\BLL\JsonLocalStorage\Departments.json"));
            Response.Tasks = JsonConvert.DeserializeObject<List<TaskDTO>>(File.ReadAllText(@"C:\Users\troni\source\repos\ClalServer\ServerTemplateSlim\BLL\JsonLocalStorage\Tasks.json"));
            return Response;
        }
    }
}
