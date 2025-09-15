



using Demo.BusinessLogic.DTOS;
using Demo.BusinessLogic.Factories;

namespace Demo.BusinessLogic.Service
{
    public class DepartmentService(IDepartmentRepository _departmentRepository) : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository = _departmentRepository;

        //Methods == > Repository
        //GET ALL == > Id , Code , Name , Decsiption , DateOfCreation [Date part only]

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {

            var departments = _departmentRepository.GetAll();
            //Mapping
            return departments.Select(d => d.ToDepartmentDto());

        }

        //GET By ID
        public DepartmentDetailsDto? GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetById(id);

            return department is null ? null : department.ToDepartmentDetailsDto();
        }



        //ADD

        public int AddDepartment(CreateDepartmentDto departmentDto)
        {

            return _departmentRepository.Add(departmentDto.ToEntity());
        }



        //UPDATE

        public int AddDepartment(UpdatedDepartmentDto departmentDto)
        {
            return _departmentRepository.Update(departmentDto.ToEntity());
        }



        //DELETE

        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null)
                return false;
            int numOfRows = _departmentRepository.Remove(department);
            return numOfRows > 0 ? true : false;

        }



    }
}

