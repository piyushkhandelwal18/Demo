namespace AjaxImageDemo.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageContent { get; set; }
        public Product Product { get; set; }
        
    }
}