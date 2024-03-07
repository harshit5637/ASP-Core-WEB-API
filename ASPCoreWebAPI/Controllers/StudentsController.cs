using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public List<string> Students = new List<string>(){
            "Harshit",
            "Mishra",
            "Abhinav",
            "Avinash",
            "Anubhav"
        };
        [HttpGet]
        public List<string> GetStudents()
        {
            return Students;
        }
        [HttpGet("{id}")]
        public string GetStudentsByIndex(int id)
        {
            return Students.ElementAt(id);
        }

    }
}
