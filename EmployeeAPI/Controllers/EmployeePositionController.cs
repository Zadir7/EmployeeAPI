using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Context;
using Microsoft.EntityFrameworkCore;
using EmployeeAPI.Models;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePositionController : ControllerBase
    {
        private readonly ApiContext _context;

        public EmployeePositionController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeePosition>>> GetEmployees()
        {
            var q = from emp in _context.Employees
                    join pos in _context.Positions
                    on emp.PositionId equals pos.ID
                    select new EmployeePosition
                    {
                        FullName = $"{emp.FirstName} {emp.LastName}", 
                        Age = emp.Age, 
                        Position = pos.PositionName 
                    };
            return await q.ToListAsync();
        }
    }
}
