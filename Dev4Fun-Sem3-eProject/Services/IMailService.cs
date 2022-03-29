using Dev4Fun_Sem3_eProject.Models;

namespace Dev4Fun_Sem3_eProject.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
