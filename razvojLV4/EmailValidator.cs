using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {
            return (candidate.Contains("@")&&(candidate.EndsWith(".hr")||candidate.EndsWith(".com")));
        }
    }
}
