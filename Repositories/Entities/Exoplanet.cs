using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Exoplanet
    {
        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Eponyn { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Star { get; private set; }

        [Required]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal Mass { get; private set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal PerioDays { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public int YearDiscover { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Distance { get; private set; }

        public Exoplanet(int id, string name, string eponyn, string star, decimal mass, decimal periodDays, int yearDiscover, string distance)
        {
            this.Id = id;
            this.Name = name;
            this.Eponyn = eponyn;
            this.Star = star;
            this.Mass = mass;
            this.PerioDays = periodDays;
            this.YearDiscover = yearDiscover;
            this.Distance = distance;
        }
    }
}
