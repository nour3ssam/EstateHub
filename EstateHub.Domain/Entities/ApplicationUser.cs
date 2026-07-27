using EstateHub.Domain.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class ApplicationUser : AuditableIdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ProfileImageUrl{ get; set; } 
        public string? Bio { get; set; } 
        public DateTime? LastLoginAt { get; set; }



        public ICollection<Property> Properties { get; set; } = [];

        public ICollection<Favorite> Favorites { get; set; } = [];

        public ICollection<Review> Reviews { get; set; } = [];

        public ICollection<Conversation> BuyerConversations { get; set; } = [];

        public ICollection<Conversation> OwnerConversations { get; set; } = [];

        public ICollection<Message> Messages { get; set; } = [];

        public ICollection<Notification> Notifications { get; set; } = [];

        public ICollection<RefreshToken> RefreshTokens { get; set; } = [];




    }
}
