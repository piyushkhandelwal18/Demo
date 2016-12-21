namespace WebApplication1.Models
{
    public class UploadImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public byte[] Image { get; set; }
    }
}