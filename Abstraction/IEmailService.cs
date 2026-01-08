namespace ProniaAdmin.Abstraction
{
    public class IEmailService
    {
        private Task SendEmailAsync(string email, string subject, string body);
    }
}
