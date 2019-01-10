﻿using System;
using JetBrains.Annotations;

namespace Volo.Abp.IdentityServer.IdentityResources
{
    public class IdentityClaim : UserClaim
    {
        public virtual Guid IdentityResourceId { get; set; }

        protected IdentityClaim()
        {

        }

        public virtual bool Equals(Guid identityResourceId, [NotNull] string type)
        {
            return IdentityResourceId == identityResourceId && Type == type;
        }

        protected internal IdentityClaim(Guid identityResourceId, [NotNull] string type)
            : base(type)
        {
            IdentityResourceId = identityResourceId;
        }

        public override object[] GetKeys()
        {
            return new object[] { IdentityResourceId, Type };
        }
    }
}