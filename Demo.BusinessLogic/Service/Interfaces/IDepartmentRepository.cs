
namespace Demo.BusinessLogic.Service
{
    internal interface IDepartmentRepository
    {
        IEnumerable<object> GetAll();
        object GetById(int id);
    }
}