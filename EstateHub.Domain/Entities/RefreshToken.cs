using EstateHub.Domain.Common;
using EstateHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstateHub.Domain.Entities
{
    internal class RefreshToken : BaseEntity
    {
        public string Token { get; set; } = string.Empty;
        public string JwtId { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }

        // Revocation
        public bool IsRevoked { get; set; }
        public DateTime? RevokedAt { get; set; }

        #region Relation With User
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        #endregion

    }
}

