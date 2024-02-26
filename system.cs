using System;
using System.Net;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        string email = "E2145116@bit.uom.lk";
        string password = "wGdtM@wUwP8263i";
        string host = "smtp.gmail.com";
        int port = 587;

        string subject = "Automated Email Response";
        string body = "Dear Mr/Mrs_____,\n\nThank you for your email. I am currently out of the office and will not have access to my email until [Date]. During this time, I will have limited availability and may not be able to respond to your message promptly.\n\nIf your matter is urgent, please contact Mr/Mrs Jane Smith at [Alternative Contact Email/Phone Number]. Otherwise, I will respond to your email as soon as possible upon my return.\n\nThank you for your understanding.\n\nBest regards,\nBineth Geenuka";

        string senderEmail = "E2145116@bit.uom.lk";
        string recipientEmail = "binethgeenuka@gmail.com";

        // Create SMTP client
        SmtpClient client = new SmtpClient(host, port)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential(email, password)
        };

        // Create email message
        MailMessage message = new MailMessage(senderEmail, recipientEmail, subject, body);

        try
        {
            // Send the email
            client.Send(message);
            Console.WriteLine("Email sent successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while sending the email: " + ex.Message);
        }
    }
}
