using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Activities
{
    public class ADApplicationScope : NativeActivity
    {
        [Browsable(false)]
        public ActivityAction<> Body { get; set; }

        [Category("Input")]
        public InArgument<string> ConnectionString { get; set; }

        public ADApplicationScope()
        {
            Body = new ActivityAction<string>
            {
                Argument = new DelegateInArgument<string>("ConnectionString"),
                Handler = new Sequence { DisplayName = "Do"}
            };
        }

        protected override void Execute(NativeActivityContext context)
        {
            throw new NotImplementedException();
        }
    }
}
