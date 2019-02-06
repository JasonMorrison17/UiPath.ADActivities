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
            var stringIn = StringArgument.Get(context);
            var result = stringIn + "_" + stringIn;
            //System.IO.File.WriteAllText(@"C:\WriteText.txt", "Log: " + StringArgument);
            //System.IO.File.WriteAllText(@"C:\WriteText.txt", "Log: " + result);
            ResultString.Set(context, result);
        }
    }
}
