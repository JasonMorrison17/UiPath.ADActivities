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
        public ActivityAction<ADProperty> Body { get; set; }

        //[Category("LDAP Information")]
        //[RequiredArgument]
        //public InArgument<string> LDAPPath { get; set; }

        //[Category("AD Crendentials")]
        //public InArgument<string> UserName { get; set; }

        //[Category("AD Crendentials")]
        //public InArgument<string> Password { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> LDAPString { get; set; }

        [Category("Input")]
        public ADAuthenticationType AuthenticationType { get; set; }

        public ADApplicationScope()
        {
            AuthenticationType = 0;
            Body = new ActivityAction<ADProperty>
            {
                Argument = new DelegateInArgument<ADProperty>("LDAPString"),
                Handler = new Sequence { DisplayName = "Do" }
            };
        }

        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);


        }

        protected override void Execute(NativeActivityContext context)
        {
            ADProperty myProperty;

            switch (AuthenticationType)
            {
                case ADAuthenticationType.Basic:
                    break;
                case ADAuthenticationType.Secure:
                    break;
                default:

                    break;
            }

            throw new NotImplementedException();
        }

        private void OnFaulted(NativeActivityFaultContext faultContext, Exception propagatedException, ActivityInstance propogatedFrom)
        {
            //TODO
            throw new NotImplementedException();
        }

        private void OnCompleted(NativeActivityContext context, ActivityInstance completedInstance)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
