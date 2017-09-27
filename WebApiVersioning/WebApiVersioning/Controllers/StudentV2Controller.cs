using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVersioning.Models;

namespace WebApiVersioning.Controllers
{
    public class StudentV2Controller : ApiController
    {
        static List<StudentV2> students = new List<StudentV2>()
        {
            new StudentV2() {Id = 1, FirstName = "Divya", LastName = "Gandivalasa"},
            new StudentV2() {Id = 2, FirstName = "Kavya", LastName = "Gandivalasa"},
        };
        //[Route("api/v2/students")]
        public IEnumerable<StudentV2> Get()
        {
            return students;
        }
        //[Route("api/v2/students/{id}")]
        public StudentV2 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
            
        }
    }
}
