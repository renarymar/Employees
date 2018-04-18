using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Класс контекста данных
/// </summary>
namespace Employees
{
    /// <summary>
    /// Строка поделючения name="DefaultConnection" connectionString="Data Source=.\hr.db" providerName="System.Data.SQLite"
    /// </summary>
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
