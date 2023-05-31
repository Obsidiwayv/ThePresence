using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace dpresence
{
    internal class Utils
    {
        public static bool StringIsValid(string cont, string i)
        {
            if (cont.Length == 0)
            {
                MessageBox.Show(i + " must not have blank characters", "Error");
                return false;
            }
            else if (cont.Length == 1)
            {
                MessageBox.Show(i + " must have 2 characters (because discord)", "Error");
                return false;
            } else
            {
                return true;
            }
        }

        public static bool IDisThere(string id)
        {
            if (id.Length == 0)
            {
                MessageBox.Show("Application ID is empty!");
                return false;
            }
            return true;
        }
    }
}
