using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Comet
    {
        [Key]
        public int Id { get; protected set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Designation { get; private set; }

        public Comet(int id, string name, string designation)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
        }
    }
}
