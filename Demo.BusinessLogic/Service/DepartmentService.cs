using Demo.DataAccess.Data.Repositories;
using Demo.DataAccess.Data.Contexts;


namespace Demo.BusinessLogic.Service
{
    internal class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        //High level modules should not depend on low level modules
        //both should depend on abstraction
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        //Methods == > Repository

    }
}

