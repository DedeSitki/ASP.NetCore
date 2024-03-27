using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    //CategoryWithProducysDto oluşturulduktan sonra oluşturuldu. Core
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _catogoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWorks, ICategoryRepository catogoryRepository, IMapper mapper) : base(repository, unitOfWorks)
        {
            _catogoryRepository = catogoryRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            var category = await _catogoryRepository.GetSingleCategoryByIdWithProductsAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryWithProductsDto>(category);
            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryDto);
        }
    }
}
