namespace NLayer.Core.DTOs
{
    //IProductRepository oluşturulma anlarından sonra oluşturuldu
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
