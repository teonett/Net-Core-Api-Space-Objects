using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreSpaceApi.Repositories.Base;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Moon
    {
        [Key]
        public int Id { get; protected set; }

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

        public Moon(int id, string name, string parent, string numeral, string radiusKm, int yearDiscover)
        {
            this.Id = id;
            this.Name = name;
            this.Parent = parent;
            this.Numeral = numeral;
            this.RadiusKm = radiusKm;
            this.YearDiscover = yearDiscover;
        }
    }
}
