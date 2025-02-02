﻿using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class CategoryWithDtoController : CustomBaseController
    {
        private readonly IServiceWithDto<Category, CategoryDto> _categoryServiceWithDto;

        public CategoryWithDtoController(IServiceWithDto<Category, CategoryDto> categoryServiceWithDto)
        {
            _categoryServiceWithDto = categoryServiceWithDto;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult (await _categoryServiceWithDto.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto category)
        {
            return CreateActionResult(await _categoryServiceWithDto.AddAsync(category));
        }
    }
}
