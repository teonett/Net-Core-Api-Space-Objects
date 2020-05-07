using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreSpaceApi.Repositories.Base;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Constelation : EntityBase
    {
        public Constelation()
        {
        }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Description { get; private set; }

        public Constelation(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
