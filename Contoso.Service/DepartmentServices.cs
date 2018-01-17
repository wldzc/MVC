using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class DepartmentServices : IDepartmentService
    {
        //Test
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentServices(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IEnumerable<Department> GetDepartment()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentByName(string name)
        {
            return _departmentRepository.GetDepartmentByName(name);
        }


    }
    public interface IDepartmentService {
        IEnumerable<Department> GetDepartment();
        Department GetDepartmentByName(string name);

    }
}
