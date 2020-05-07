using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreSpaceApi.Repositories.Base;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Comet : EntityBase
    {
        public Comet()
        {
        }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Designation { get; private set; }

        public Comet(string name, string designation)
        {
            this.Name = name;
            this.Designation = designation;
        }
    }
}
