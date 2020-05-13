using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Lab6.Wcf.Contracts
{
    [DataContract]
    public class PostDto
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Domain { get; set; }

        [DataMember]
        public IEnumerable<CommentDto> Comments { get; set; }
    }
}