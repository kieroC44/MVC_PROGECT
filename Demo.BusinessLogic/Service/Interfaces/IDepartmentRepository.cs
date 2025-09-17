
namespace Demo.BusinessLogic.Service
{
    public interface IDepartmentRepository
    {
        IEnumerable<object> GetAll();
        object GetById(int id);
    }
}