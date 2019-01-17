using System;
using System.Collections.Generic;
using System.Text;

namespace JView.Domain
{
    public class MobileServiceProvider
    {
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string DomainName { get; set; }
        public bool Active { get; set; }
    }
}
