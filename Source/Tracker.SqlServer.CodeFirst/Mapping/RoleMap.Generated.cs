﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tracker.SqlServer.CodeFirst.Mapping
{
    public partial class RoleMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tracker.SqlServer.CodeFirst.Entities.Role>
    {
        public RoleMap()
        {
            // table
            ToTable("Role", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(150)
                .IsOptional();
            Property(t => t.CreatedDate)
                .HasColumnName("CreatedDate")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();
            Property(t => t.RowVersion)
                .HasColumnName("RowVersion")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasMaxLength(8)
                .IsRowVersion()
                .IsRequired();

            // Relationships
            HasMany(t => t.Users)
                .WithMany(t => t.Roles)
                .Map(m =>
                {
                    m.ToTable("UserRole", "dbo");
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("UserId");
                });

            InitializeMapping();
        }
    }
}

