using Demo.BusinessLogic.DTOS;

namespace Demo.BusinessLogic.Service
{
    public interface IDepartmentService
    {
        int AddDepartment(CreateDepartmentDto departmentDto);
        int AddDepartment(UpdatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetailsDto? GetDepartmentById(int id);
    }
}