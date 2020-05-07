using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreSpaceApi.Repositories.Base;

namespace NetCoreSpaceApi.Repositories.Entities
{
    public class Galaxy : EntityBase
    {
        public Galaxy()
        {
        }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string Name { get; private set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Constelation { get; private set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string OriginName { get; private set; }

        public Galaxy(string name, string constelation, string originName)
        {
            this.Name = name;
            this.Constelation = constelation;
            this.OriginName = originName;
        }
    }
}
