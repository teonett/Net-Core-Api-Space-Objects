using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreSpaceApi.Repositories.Base;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Star : EntityBase
    {
        public Star()
        {
        }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Constelation { get; private set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string RightType { get; private set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string ApparentMo { get; private set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string SpectralGyr { get; private set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Mass { get; private set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Temperature { get; private set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Age { get; private set; }

        public Star(string name, string constelation, string rightType, string apparentMo, string spectralGyr, string mass, string temperature, string age)
        {
            this.Name = name;
            this.Constelation = constelation;
            this.RightType = rightType;
            this.ApparentMo = apparentMo;
            this.SpectralGyr = spectralGyr;
            this.Mass = mass;
            this.Temperature = temperature;
            this.Age = age;
        }
    }
}
