//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.OData.Query;
//using OData6Demo.Models;
//using OData6Demo.Services;

//namespace OData6Demo.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class StudentsController : ControllerBase
//    {
//        private readonly IStudentService studentService;

//        public StudentsController(IStudentService studentService) =>
//            this.studentService = studentService;

//        [HttpGet]
//        [EnableQuery]
//        public ActionResult<IQueryable<Student>> GetAllStudents()
//        {
//            IQueryable<Student> retrievedStudents =
//                this.studentService.RetrieveAllStudents();

//            return Ok(retrievedStudents);
//        }
//    }
//}
