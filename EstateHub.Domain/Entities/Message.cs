using EstateHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class Message : BaseEntity
    {
        public string Content { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }

        public Guid SenderId { get; set; }
        public ApplicationUser Sender { get; set; } = null!;
        public Guid ConversationId { get; set; }
        public Conversation Conversation { get; set; } = null!;
    }
}
