using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
  public class SupplierModel
    {
        public int ID { get; set; }
        public string BusinessName { get; set; }
        public string ShortName { get; set; }
        public string BusinessType { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string LandLine { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public Nullable<int> DefaultBankID { get; set; }
        public string AccountNo { get; set; }
        public bool Active { get; set; }
        public Nullable<int> PaymentDays { get; set; }
    }

    public class SupplierEditModel{
        public int ID { get; set; }
        public string BusinessName { get; set; }
        public string ShortName { get; set; }
        public string BusinessType { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string LandLine { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public Nullable<int> DefaultBankID { get; set; }
        public string AccountNo { get; set; }
        public bool Active { get; set; }
        public Nullable<int> PaymentDays { get; set; }

    }
}
