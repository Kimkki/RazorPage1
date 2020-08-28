using RazorPage.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPages.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee() {Id= 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com", PhotoPath="mary.jpg"},
                new Employee() {Id= 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com", PhotoPath="john.jpg"},
                new Employee() {Id= 3, Name = "Sarah", Department = Dept.IT, Email = "sarah@gmail.com", PhotoPath="sarah.jpg"},
                new Employee() {Id= 4, Name = "David", Department = Dept.Payroll, Email = "david@gmail.com"}

            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }
    }
}
