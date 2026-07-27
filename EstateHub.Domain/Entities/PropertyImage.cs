using EstateHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class PropertyImage: BaseEntity
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string PublicId { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }

        // Relation with Property
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = null!;
    }
}
