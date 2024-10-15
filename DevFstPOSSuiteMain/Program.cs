using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevFstPOSSuite.Models;
using DevFstPOSSuite.Windowforms;

namespace DevFstPOSSuite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               // Application.Run(new Main());
                Application.Run(new UserLogin());
              // Application.Run(new Test());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.AbortRetryIgnore);

            }
        }
    }
}
