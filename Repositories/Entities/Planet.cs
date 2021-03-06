﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Planet
    {
        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal DiameterKm { get; private set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string SizeRelative { get; private set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string SunDistance { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string MassKg { get; private set; }

        [Required]
        public int Moons { get; private set; }

        public Planet(int id, string name, decimal diameterKm, string sizeRelative, string sunDistance, string massKg, int moons)
        {
            this.Id = id;
            this.Name = name;
            this.DiameterKm = diameterKm;
            this.SizeRelative = sizeRelative;
            this.SunDistance = sunDistance;
            this.MassKg = massKg;
            this.Moons = moons;
        }
    }
}
