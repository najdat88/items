using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Najd.Md.Items
{
    public interface IItemAppService : IApplicationService 
    {
        Task<ListResultDto<ItemDto>> GetListAsync(GetItemListDto input);
        Task<ItemDto> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task<ItemDto> InsertAsync(CreateItemDto input);
        Task<ItemDto> InsertJsonAsync(string values);
        Task<ItemDto> UpdateAsync(Guid id, UpdateItemDto input);
        Task<ItemDto> UpdateJsonAsync(Guid id, string values);
        //Task UpdateItemPrice(Guid Key, decimal Cost, decimal Price, decimal AgentPrice);
    }
}