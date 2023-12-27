using LibraryApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public string ExportEmployeesToCsv()
        {
            var employees = _dbContext.Employees.ToList();

            // Créer une ligne d'en-tête CSV
            var csvContent = new StringBuilder();
            csvContent.AppendLine("ID,Nom,Prénom,Email,Rôle");

            // Ajouter chaque employé comme une ligne CSV
            foreach (var employee in employees)
            {
                csvContent.AppendLine($"{employee.Id},{employee.Name},{employee.FirstName},{employee.Email},{employee.Role}");
            }

            return csvContent.ToString();
        }
    }
}
