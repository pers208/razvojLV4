using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
