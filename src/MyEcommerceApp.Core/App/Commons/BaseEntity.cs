using Abp.Authorization.Users;
using Abp.Domain.Entities;
using MyEcommerceApp.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEcommerceApp.App.Commons
{
    public class BaseEntity: Entity<Guid>
    {
        public DateTime CreationDateTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastUpateDateTime { get; set; }
        public long? LastUpdateUserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        [ForeignKey(nameof(CreatorUserId))]
        public AbpUser<User> CreatorUser { get; set; }

        [ForeignKey(nameof(LastUpdateUserId))]
        public AbpUser<User> LastUpdateUser { get; set; }
    }
}
