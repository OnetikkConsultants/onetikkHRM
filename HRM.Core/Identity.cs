using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace HRM.Core
{
    public class HRMPrincipal : IPrincipal
    {

        public HRMPrincipal(HRMIdentityDetails principalDetails)
        {
            this.Identity = new HRMIdentity(principalDetails);
        }

        public HRMPrincipal(HRMIdentity identity)
        {
            this.Identity = identity;
        }

        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            // Check parameters
            Require.NotNullOrEmpty(role, "role");

            // Check if our roles list contains a matching role name
            if (((HRMIdentity)this.Identity).Roles.Any(role.Contains))
            {
                return true;
            }

            return false;
        }
    }

    public class HRMIdentity : GenericIdentity
    {
        private readonly HRMIdentityDetails details;

        internal HRMIdentity(HRMIdentityDetails details)
            : base(details.Email)
        {
            this.details = details;
        }

        public Guid UserId
        {
            get
            {
                return this.details.UserId;
            }
        }

        public string Email
        {
            get
            {
                return this.details.Email;
            }
        }

        public string[] Roles
        {
            get
            {
                return this.details.Roles;
            }
        }
    }

    public class HRMIdentityDetails
    {
        public Guid UserId { get; set; }

        public string Email { get; set; }

        public string[] Roles { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static HRMIdentityDetails FromJson(string json)
        {
            Require.NotNullOrEmpty(json, "json");
            return JsonConvert.DeserializeObject<HRMIdentityDetails>(json);
        }
    }
}
