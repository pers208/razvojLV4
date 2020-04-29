using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    class UserValidator : IRegistrationValidator
    {
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;
        public UserValidator(EmailValidator emailValidator, PasswordValidator passwordValidator) {
            this.passwordValidator = passwordValidator;
            this.emailValidator = emailValidator;
        }
        public UserValidator()
        {
            this.passwordValidator = new PasswordValidator(6);
            this.emailValidator = new EmailValidator();
        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            return (passwordValidator.IsValidPassword(entry.Password)&&emailValidator.IsValidAddress(entry.Email));
        }
    }
}
