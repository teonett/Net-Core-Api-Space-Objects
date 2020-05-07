using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreSpaceApi.Repositories.Base;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Moon : EntityBase
    {
        public Moon()
        {
        }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Parent { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Numeral { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string RadiusKm { get; private set; }

        [Required]
        public int YearDiscover { get; private set; }

        public Moon(string name, string parent, string numeral, string radiusKm, int yearDiscover)
        {
            this.Name = name;
            this.Parent = parent;
            this.Numeral = numeral;
            this.RadiusKm = radiusKm;
            this.YearDiscover = yearDiscover;
        }
    }
}
