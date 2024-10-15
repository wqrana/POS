using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevFstPOSSuite.DAL;
using DevFstPOSSuite.Models;

using MetroFramework.Forms;

namespace DevFstPOSSuite.Windowforms
{
    public partial class UserLogin : MetroForm  
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (userTxt.Text == "" || pwdTxt.Text == "")
            {

                MessageBox.Show("Missing either User or Password", "Missing Detail");
            }
            using (var context = new RetailDBEntities1())
            {

                var user = context.AuthenticationRules.Where(x => x.UserName.ToLower() == userTxt.Text.ToLower() && x.Pass == pwdTxt.Text).Select(a => new UserModel{ ID=a.ID, UserName=a.UserName, IbReports = a.IbReports ?? false, Ibsales = a.Ibsales ?? false, Ibinventory = a.Ibinventory?? false , UserType = a.UserType, IbFinance = a.IbFinance??false }).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Invalid User or Password", "Invalid Login");
                    return;
                }
                else
                {
                    var payment_dd = context.CNF_AppConfiguration.Select(s => s.PaymentDays).FirstOrDefault();
                    Global.userID = user.ID;
                    Global.userLogin = user.UserName;
                    Global.userModel = user;
                    Global.paymentDays = payment_dd??0;
                    
                    this.Visible = false;

                    Main m = new Main();
                    m.Visible = true;


                }
            } 
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            userTxt.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserLogin_Shown(object sender, EventArgs e)
        {
            userTxt.Focus();
           
        }
    }
}
