﻿using Entity.Dtos.Category;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<CategoryDto>>> GetCategoriesWithPagination(int page, int pageSize);
        Task<ServiceResponse<IEnumerable<CategoryDtoVerCus>>> GetCategoriesVerCusWithPagination(int page, int pageSize);
        Task<ServiceResponse<int>> CountCategoriesVerCusWithPagination();
        Task<ServiceResponse<CategoryDto>> GetCategoryById(int id);
        Task<ServiceResponse<int>> CountCategories();
        Task<ServiceResponse<string>> DisableOrEnableCategory(int id);
        Task<ServiceResponse<int>> CreateNewCategory(Category category);
        Task<ServiceResponse<Category>> UpdateCategory(int id, Category category);
    }
}
