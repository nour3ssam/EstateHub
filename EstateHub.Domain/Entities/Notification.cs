using EstateHub.Domain.Common;
using EstateHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class Notification : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public NotificationType Type { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
        public Guid? RelatedEntityId { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}
