namespace Dev4Fun_Sem3_eProject.Models
{
    public class ApplicantVacancy
    {
        public int Id { get; set; }
        public string VacancyId { get; set; }
        public string ApplicantId { get; set; }
        public string InterviewerId { get; set; }
        public string CreatedById { get; set; }
        public DateTime DateOfAttach { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public int Status { get; set; }
    }
}
