using EstateHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class Conversation : BaseEntity
    {
        public Guid BuyerId { get; set; }
        public Guid OwnerId { get; set; }
        public Guid PropertyId { get; set; }
        public DateTime? LastMessageAt { get; set; }

        public ApplicationUser Buyer { get; set; } = null!;
        public ApplicationUser Owner { get; set; } = null!;
        public Property Property { get; set; } = null!;
        public ICollection<Message> Messages { get; set; } = [];
    }

}
