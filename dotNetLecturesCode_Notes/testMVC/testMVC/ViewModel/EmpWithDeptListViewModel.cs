﻿using System.ComponentModel.DataAnnotations.Schema;
using testMVC.Models;

namespace testMVC.ViewModel
{
    public class EmpWithDeptListViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Salary { get; set; }
        public string? JobTitle { get; set; }
        public string? ImageURL { get; set; }
        public string? Address { get; set; }
        
        public int DepartmentId { get; set; }
        public List<Department> DeptList { get; set; }
    }
}
