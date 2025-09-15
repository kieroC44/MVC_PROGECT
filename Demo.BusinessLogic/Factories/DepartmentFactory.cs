

using Demo.BusinessLogic.DTOS;
using Demo.DataAccess.Models;
using System.Runtime.CompilerServices;

namespace Demo.BusinessLogic.Factories
{
    internal static class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department d)
        { 
        return new DepartmentDto()
            {
                DeptId = d.Id,
                Code = d.Code,
                Name = d.Name,
                Description = d.Description,
                DateOfCreation = d.CreatedOn.HasValue ? DateOnly.FromDateTime(d.CreatedOn.Value) : default
            };

        }

        public static DepartmentDetailsDto ToDepartmentDetailsDto(this Department department)
        {
            return new DepartmentDetailsDto()
            {
                Id = department.Id,
                Code = department.Code,
                Description = department.Description,
                Name = department.Name,
                CreatedBy = department.CreatedBy,
                CreatedOn = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : default,
                ModifiedBy = department.ModifiedBy,
                ModifiedOn = department.ModifiedOn.HasValue ? DateOnly.FromDateTime(department.ModifiedOn.Value) : default
            };





        }

        public static Department ToEntity(this CreateDepartmentDto departmentDto)
        {
            return new Department()
            {
                Description = departmentDto.Description,
                Name = departmentDto.Name,
                Code = departmentDto.Code,
                //DateOnly == > DateTime
                CreatedOn = departmentDto.DateOfCreation.ToDateTime(new TimeOnly())
            };
        }


        public static Department ToEntity(this UpdatedDepartmentDto departmentDto)
        {
            return new Department()
            {
                Id = departmentDto.Id,
                Description = departmentDto.Description,
                Name = departmentDto.Name,
                Code = departmentDto.Code,
                //DateOnly == > DateTime
                CreatedOn = departmentDto.DateOfCreation.ToDateTime(new TimeOnly())
            };
        }





    }
}
