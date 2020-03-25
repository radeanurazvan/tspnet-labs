using System.Runtime.Serialization;

namespace Lab6.Wcf.Contracts
{
    [DataContract]
    public class CommentDto
    {
        [DataMember]
        public string Text { get; set; }
    }
}