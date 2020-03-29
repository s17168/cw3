using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cw3WebApplication.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2) {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono podanego studenta");
        }

        [HttpGet]
        public string GetStudents([FromQuery] string orderBy) 
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student) 
        {
            student.IndexNumber = $"s{new Random().Next(1, 10000)}";

            return Ok(student);
        }

    }

}