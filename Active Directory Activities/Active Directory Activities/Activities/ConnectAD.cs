using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
using System.DirectoryServices;

namespace ADActivities.Activities
{
    public class ConnectAD : NativeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> StringArgument { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<string> ResultString { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            GetDirectoryEntry();
        }

        //public static DirectoryEntry GetDirectoryEntry()
        //{
        //    DirectoryEntry de = new DirectoryEntry();
        //    de.Path = "LDAP://172.20.59.55/CN=Orch1;DC=Peronsal.UiPath";
        //    de.Username = @"";
        //    de.Password = "samplepassword";
        //    return de;
        //}

        public static DirectoryEntry GetDirectoryEntry()
        {
            DirectoryEntry de = new DirectoryEntry();
            de.Path = "LDAP://ldap.forumsys.com:389/CN=admin;DC=example";
            de.AuthenticationType = AuthenticationTypes.Secure;
            return de;
        }


    }
}
