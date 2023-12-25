using LibraryApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp.Services
{
    public class LibraryService
    {
        private readonly LibraryDbContext _dbContext;

        public LibraryService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        // Ajoutez d'autres méthodes pour effectuer des opérations CRUD sur les employés
        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _dbContext.Employees.Find(employee.Id);

            if (existingEmployee != null)
            {
                // Update properties
                existingEmployee.Name = employee.Name;
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.Email = employee.Email;
                existingEmployee.Role = employee.Role;

                _dbContext.SaveChanges();
            }

        }

        public void DeleteEmployee(int employeeId)
        {
            var employeeToDelete = _dbContext.Employees.Find(employeeId);

            if (employeeToDelete != null)
            {
                _dbContext.Employees.Remove(employeeToDelete);
                _dbContext.SaveChanges();
            }
        }

    }
}
