using EstateHub.Domain.Common;
using EstateHub.Domain.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class Property : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public bool IsWhatsAppVisible { get; set; }
        public string? WhatsAppNumber { get; set; }

        public ListingType ListingType { get; set; }
        public PropertyStatus Status { get; set; }
        public PropertyType PropertyType { get; set; }

        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public decimal AreaInSquareMeters { get; set; }
        public int? Floor { get; set; }

        public string City { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public Guid OwnerId { get; set; } 
        public ApplicationUser Owner { get; set; } = null!;
        public ICollection<PropertyImage> Images { get; set; } = [];
        public ICollection<Conversation> Conversations { get; set; } = [];
        public ICollection<Favorite> Favorites { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
