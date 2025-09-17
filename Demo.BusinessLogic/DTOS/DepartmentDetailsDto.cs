
namespace Demo.BusinessLogic.DTOS
{
    public class DepartmentDetailsDto
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; } //User Id
        public DateOnly? CreatedOn { get; set; } //The date time of creating the record
        public int ModifiedBy { get; set; } //User Id
        public DateOnly? ModifiedOn { get; set; }//The date time of modifing the record

        public bool IsDeleted { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
