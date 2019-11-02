using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Wallpaper_Generator.Classes
{
    class Access
    {

        // z neta
        public static void GrantAccess(string file)
        {
            // sprawdza czy katalog istnieje
            bool exists = Directory.Exists(file);
            if (!exists)
            {
                // tworzy
                DirectoryInfo di = Directory.CreateDirectory(file);
            }

            //nadaje mu uprawniena (co tu się stanęło?)
            DirectoryInfo dInfo = new DirectoryInfo(file);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), 
                FileSystemRights.FullControl, 
                InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, 
                PropagationFlags.NoPropagateInherit, 
                AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
