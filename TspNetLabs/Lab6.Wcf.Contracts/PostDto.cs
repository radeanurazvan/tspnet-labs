using System.Runtime.Serialization;

namespace Lab6.Wcf.Contracts
{
    [DataContract]
    public class PostDto
    {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Domain { get; set; }
    }
}