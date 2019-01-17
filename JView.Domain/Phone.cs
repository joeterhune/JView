using System;
using System.Collections.Generic;
using System.Text;

namespace JView.Domain
{
    class Phone
    {
        public int PhoneID { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        public int ProviderID { get; set; }
        public bool IsPrimary { get; set; }
        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType {
        Home=1,
        Work=2,
        Mobile=3,
        Fax=4,
        Pager=5

    }
}
