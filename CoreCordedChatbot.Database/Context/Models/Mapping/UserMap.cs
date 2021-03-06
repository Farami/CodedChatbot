﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(t => t.Username);

            builder.Property(t => t.Username).HasColumnName("Username").IsRequired();
            builder.Property(t => t.UsedVipRequests).HasColumnName("UsedVipRequests").IsRequired();
            builder.Property(t => t.ModGivenVipRequests).HasColumnName("ModGivenVipRequests").IsRequired();
            builder.Property(t => t.FollowVipRequest).HasColumnName("FollowVipRequest").IsRequired();
            builder.Property(t => t.SubVipRequests).HasColumnName("SubVipRequests").IsRequired();
            builder.Property(t => t.DonationOrBitsVipRequests).HasColumnName("DonationOrBitsVipRequests").IsRequired();
        }
    }
}
