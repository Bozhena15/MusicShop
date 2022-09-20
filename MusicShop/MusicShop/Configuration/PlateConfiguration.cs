using Microsoft.EntityFrameworkCore;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Configuration
{
    internal class PlateConfiguration : IEntityTypeConfiguration<Plate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plate> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.GenreId);
            builder.Property(p => p.EditionId);
            builder.Property(p => p.AuthorId);
            builder.Property(p => p.TrackCount);
            builder.Property(p => p.Year).IsRequired();
            builder.Property(p => p.PlatePrice).IsRequired();
            builder.Property(p => p.PlateCost).IsRequired();


        }
    }
}
