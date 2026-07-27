using EstateHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class Favorite : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = null!;
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}
