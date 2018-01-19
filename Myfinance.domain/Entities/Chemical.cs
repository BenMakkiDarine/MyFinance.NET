using Myfinance.domain.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.domain.Entities
{
    public class Chemical : Product
    {
        public string LabName { get; set; }
        public Address address { get; set; }


    }
}
