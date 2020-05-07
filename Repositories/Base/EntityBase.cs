using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NetCoreSpaceApi.Repositories.Base
{
    [DataContract]
    public class EntityBase
    {
        [DataMember]
        [Key]
        public int Id { get; protected set; }
    }
}
