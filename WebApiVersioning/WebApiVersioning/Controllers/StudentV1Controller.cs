using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVersioning.Models;

namespace WebApiVersioning.Controllers
{
    public class StudentV1Controller : ApiController
    {
        static List<StudentV1> students = new List<StudentV1>()
        {
            new StudentV1() {Id = 1, Name = "Divya"},
            new StudentV1() {Id = 2, Name = "Kavya"},
        };
        //[Route("api/v1/students")]
        public IEnumerable<StudentV1> Get()
        {
            return students;
        }
        //[Route("api/v1/students/{id}")]
        public StudentV1 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
            
        }
    }
}
