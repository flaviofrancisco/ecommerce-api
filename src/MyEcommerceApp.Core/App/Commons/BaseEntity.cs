using Abp.Authorization.Users;
using Abp.Domain.Entities;
using MyEcommerceApp.Authorization.Users;
using MyEcommerceApp.MultiTenancy;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Commons
{
    public class BaseEntity: Entity<Guid>
    {
        public long? DeleterUserId { get; set; }

        [ForeignKey(nameof(DeleterUserId))]
        public User DeleterUser { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastUpateDateTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? TenantId { get; set; }

        [ForeignKey(nameof(CreatorUserId))]
        public User CreatorUser { get; set; }

        [ForeignKey(nameof(LastModifierUserId))]
        public User LastModifierUser { get; set; }

        [ForeignKey(nameof(TenantId))]
        public Tenant Tenant { get; set; }

    }
}
