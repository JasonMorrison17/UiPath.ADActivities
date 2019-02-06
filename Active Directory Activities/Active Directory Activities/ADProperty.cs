using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace ADActivities
{
    public enum ADAuthenticationType
    {
        Select,
        Basic,
        Secure
    }

    public class ADProperty
    {
        public DirectoryEntry connection;

        public static ADProperty Create()
        {
            return new ADProperty();
        }
    }
}
