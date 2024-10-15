using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFstPOSSuite.Models
{
  public class UserModel
    {

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public bool Ibsales { get; set; }
        public bool Ibinventory { get; set; }
        public bool IbFinance { get; set; }
        public bool IbReports { get; set; }
        public bool Active { get; set; }
    }

  public class UserEditModel
  {
      public int ID { get; set; }
      public string UserName { get; set; }
      public string Pass { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string UserType { get; set; }
      public bool Ibsales { get; set; }
      public bool Ibinventory { get; set; }
      public bool IbFinance { get; set; }
      public bool IbReports { get; set; }
      public bool Active { get; set; }

  }

  public class UserRightsModel
  {
      public int ID { get; set; }
      public string UserName { get; set; }
      public string ObjectName { get; set; }
      public string ObjectTextName { get; set; }
      public Nullable<bool> Viewable { get; set; }
      public Nullable<bool> Updatable { get; set; }
      public Nullable<bool> Deletable { get; set; }
  }

}
