using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context) : base(context)
        {

        }

        public Department GetDepartmentByName(string name)
        {
            var department = _context.Departments.OfType<Department>().FirstOrDefault(s=>s.Name == name);
            return department;
        }
    }
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department GetDepartmentByName(string  name);
        
    }
}
