

using Demo.DataAccess.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo.DataAccess.Data.Repositories
{
    public class DepartmentRepository(ApplicationDbContext _dbContext) : IDepartmentRepository
    {
        //1] Inject object needed
        //2] LifeTime [Memory]

        //5 CRUD OPERATIONS
        //GET ALL
        public IEnumerable<Department> GetAll(bool withTracking = false)
        {

            if (withTracking)
                return _dbContext.Departments.ToList();
            else
                return _dbContext.Departments.AsNoTracking().ToList();
        }
        //GET BY ID



        public Department? GetById(int id) => _dbContext.Departments.Find(id);

        //ADD
        public int Add(Department department)
        {
            _dbContext.Departments.Add(department); //Add locally
            return _dbContext.SaveChanges();
        }

        //UPDATE
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges(); // num of rows affected
        }
        //REMOVE
        public int Remove(Department department)
        {
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }

    }
}
