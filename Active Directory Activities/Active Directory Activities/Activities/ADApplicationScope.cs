using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADActivities.Activities
{
    class ADApplicationScope : NativeActivity
    {
        [Browsable(false)]
        public ActivityAction<T> Body { get; set; }

        [Category("Input")]
        public InArgument<string> ConnectionString { get; set; }

        public ADApplicationScope()
        {
            Body = new ActivityAction<T>
            {
                Argument = new DelegateInArgument<T>("ConnectionString"),
                Handler = new Sequence { DisplayName = "Do" }
            };
        }

        protected override void Execute(NativeActivityContext context)
        {
            throw new NotImplementedException();
        }
    }
}
