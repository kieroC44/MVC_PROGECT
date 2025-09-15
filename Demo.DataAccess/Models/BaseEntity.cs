namespace Demo.DataAccess.Models
{
    internal class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; } //User Id
        public DateTime? CreatedOn { get; set; } //The date time of creating the record
        public int ModifiedBy { get; set; } //User Id
        public DateTime? ModifiedOn { get; set; }//The date time of modifing the record

        public bool IsDeleted { get; set; } //Soft delete
    }
}
