

using Demo.DataAccess.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccess.Data.Repositories
{
    internal class DepartmentRepository(ApplicationDbContext _dbContext)
    {
            //1] Inject object needed
            //2] LifeTime [Memory]

        //5 CRUD OPERATIONS
        //GET ALL
        //GET BY ID


        public Department? GetById(int id)
        {
            var department = _dbContext.Departments.Find(id);
            return department;
        }
        //ADD
        //UPDATE
        //REMOVE


    }
}
