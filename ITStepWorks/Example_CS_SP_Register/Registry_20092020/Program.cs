using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Example_CS_SP_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            int autoRunValue = (int)Registry.LocalMachine
                .OpenSubKey("SYSTEM")
                .OpenSubKey("CurrentControlSet")
                .OpenSubKey("services")
                .OpenSubKey("cdrom")
                .GetValue("AutoRun");


            string user = Environment.UserDomainName + "\\" + Environment.UserName;

            RegistrySecurity rs = new RegistrySecurity();

            // Allow the current user to read and delete the key.
            //
            //rs.AddAccessRule(new RegistryAccessRule(user,
            //    RegistryRights.ReadKey | RegistryRights.Delete | RegistryRights.SetValue,
            //    InheritanceFlags.None,
            //    PropagationFlags.None,
            //    AccessControlType.Allow));


            Registry.LocalMachine
                .OpenSubKey("SYSTEM")
                .OpenSubKey("CurrentControlSet")
                .OpenSubKey("services")
                .OpenSubKey("cdrom", RegistryKeyPermissionCheck.ReadWriteSubTree)
                .SetValue("AutoRun", 0);



        }
    }
}
