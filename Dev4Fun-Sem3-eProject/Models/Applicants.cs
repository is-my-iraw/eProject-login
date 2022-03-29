namespace Dev4Fun_Sem3_eProject.Models
{
    public class Applicants
    {
        public int Id { get; set; }
        public string ApplicantNumber { get; set; }
        public string ApplicantName { get; set; }
        public string Birthday { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageAvatar { get; set; }
        public int Status { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfUpdate { get; set; }

    }
}
