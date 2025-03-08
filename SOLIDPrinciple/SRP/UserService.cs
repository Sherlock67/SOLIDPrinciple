using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.SRP
{
    public class UserService
    {
        EmailService _emailService;

        public UserService(EmailService aEmailService)
        {
            _emailService = aEmailService;
        }
        //SRP says, "Every software module should have only one reason to change.".
        //It is done purposely. My goal is not make the structure which follow Single Responsibility Principle
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);
            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

            //SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }

    }
}
