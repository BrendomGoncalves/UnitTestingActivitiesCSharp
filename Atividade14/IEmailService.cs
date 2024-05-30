namespace Atividade14
{
    public interface IEmailService
    {
        void SendEmail(string recipient, string subject, string body);
    }
}
