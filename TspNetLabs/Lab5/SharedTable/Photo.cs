namespace Lab5.SharedTable
{
    public class Photo : Entity
    {
        public string Title { get; set; }

        public byte[] Bits { get; set; }

        public PhotoFullImage FullImage { get; set; }
    }

    public class PhotoFullImage : Entity
    {
        public byte[] HighResolutionBits { get; set; }

        public Photo Photo { get; set; }
    }
}