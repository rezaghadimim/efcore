// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Scaffolding
{
    public partial class DbContextModel
    {
        private DbContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 4)
        {
        }

        partial void Initialize()
        {
            var index = IndexEntityType.Create(this);
            var scaffolding = ScaffoldingEntityType.Create(this);
            var identityUser = IdentityUserEntityType.Create(this);
            var identityUser0 = IdentityUser0EntityType.Create(this, identityUser);

            IndexEntityType.CreateAnnotations(index);
            ScaffoldingEntityType.CreateAnnotations(scaffolding);
            IdentityUserEntityType.CreateAnnotations(identityUser);
            IdentityUser0EntityType.CreateAnnotations(identityUser0);

        }
    }
}