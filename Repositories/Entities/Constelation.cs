using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Constelation
    {
        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Description { get; private set; }

        public Constelation(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
