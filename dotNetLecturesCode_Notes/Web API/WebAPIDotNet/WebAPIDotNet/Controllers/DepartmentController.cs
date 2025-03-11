using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDotNet.DTO;
using WebAPIDotNet.Models;

namespace WebAPIDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        ITIContext context;
        public DepartmentController(ITIContext _Context)
        {
            context = _Context;
        }
        [HttpGet("p")]
        [Authorize] //reply not found as it check first the cookie then check "/account/login" not "/api/account/login" so edit it in middleware
        public ActionResult<List<DeptWithEmpCountDTO>> GetDeptDetails()
        {
            List<Department> deptList = context.Department.Include(d=>d.Employees).ToList();
            List<DeptWithEmpCountDTO> deptListDTO = new List<DeptWithEmpCountDTO>();
            foreach (var dept in deptList)
            {
                DeptWithEmpCountDTO deptDTO = new DeptWithEmpCountDTO();
                deptDTO.Id = dept.Id;
                deptDTO.Name = dept.Name;
                deptDTO.EmpCount = dept.Employees.Count;
                deptListDTO.Add(deptDTO);
            }
            return deptListDTO;//Action Result
            //return Ok(deptListDTO);//IActionResult
        }

        //api/department verb get
        [HttpGet]
        public IActionResult DisplayAllDept()
        {
            List<Department> deptList = context.Department.ToList();
            return Ok(deptList);//status code 200   
        }

        //api/department/1 verb get
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetByID(int id) {
            Department dept = context.Department.FirstOrDefault(d => d.Id == id);
            return Ok(dept);
        }

        [HttpGet("{name:alpha}")]
        public IActionResult GetByName(string name)
        {
            Department dept = context.Department.FirstOrDefault(d => d.Name == name);
            return Ok(dept);
        }
        //api/department verb post
        [HttpPost]
        public IActionResult AddDept(Department dept)
        {
            context.Department.Add(dept);
            context.SaveChanges();
            //return Created($"http://localhost:9305/api/department/{dept.Id}", dept);
            return CreatedAtAction("GetByID",new {id=dept.Id},dept);
        }
        //api/department verb put
        [HttpPut("{id:int}")]
        public IActionResult UpdateDept(int id, Department deptFromRequest)
        {
            Department deptFromDB =
            context.Department.FirstOrDefault(d => d.Id == id);
            if (deptFromDB != null)
            {

                deptFromDB.Name = deptFromRequest.Name;
                deptFromDB.ManagerName = deptFromRequest.ManagerName;
                context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound($"No department found with id {id}");
            }
        }

        //api/department verb delete
        [HttpDelete]
        public IActionResult DeleteDept(int id)
        {
            Department dept = context.Department.FirstOrDefault(d => d.Id == id);
            if (dept != null)
            {
                context.Department.Remove(dept);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound($"No department found with id {id}");
            }
        }
    }
}
