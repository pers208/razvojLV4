using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}
