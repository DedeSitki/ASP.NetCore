namespace NLayer.Core.DTOs
{
    //ICategoryService oluşturulduktan sonra oluşturuldu. Core
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
