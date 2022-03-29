namespace Dev4Fun_Sem3_eProject.Models
{
    public class Vacancies
    {

        public int Id { get; set; }
        public string OwnedID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfJobs { get; set; }
        public int Status { get; set; }
        public string ApplicantId { get; set; }
        public string DepartmentId { get; set; }
        public string Thumbnail { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int Views { get; set; }
        public int Experience { get; set; }
        public string CareerLevel { get; set; }
        public string Qualification { get; set; }
        public DateTime DateOfExpiration { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfUpdate { get; set; }

    }
}
