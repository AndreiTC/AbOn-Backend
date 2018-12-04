using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models.UserAggregate
{
    public class Password
    {
        public byte[] Salt { get; set; }
        public string Hash { get; set; }
    }
}
