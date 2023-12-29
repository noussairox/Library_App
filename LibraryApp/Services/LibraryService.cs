using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public Employee AuthenticateUser(string username, string password)
        {
            // Recherchez l'utilisateur par email
            var user = _dbContext.Employees.SingleOrDefault(e => e.Email == username);

            if (user != null)
            {
                // Vérifiez le mot de passe hashé avec SHA-256
                if (VerifyHashedPassword(password, user.PasswordHash))
                {
                    return user;
                }
            }

            return null;
        }

        public void HashAndSetPassword(Employee employee, string password)
        {
            // Hash du mot de passe avec SHA-256 
            employee.PasswordHash = HashPassword(password);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // Convertit le mot de passe en tableau de bytes
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertit le tableau de bytes en une chaîne hexadécimale
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private bool VerifyHashedPassword(string password, string hashedPassword)
        {
            // Vérifie le mot de passe en comparant les hachages
            return string.Equals(hashedPassword, HashPassword(password));
        }
    }
}
