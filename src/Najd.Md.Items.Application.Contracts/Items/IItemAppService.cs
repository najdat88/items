using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Najd.Md.Items
{
    public interface IItemAppService : IApplicationService 
    {
        Task<ItemDto> GetAsync(Guid id);

        Task<List<ItemDto>> GetListAsync(GetItemListDto input);
        Task<ItemDto> Insert(string Values, Guid? Category_Id);
        Task<ItemDto> Update(Guid Key, string Values);
        Task Delete(Guid Id);
        Task UpdateItemPrice(Guid Key, decimal Cost, decimal Price, decimal AgentPrice);
        Task UpdateItemPayLoad(Guid Key, string Values);
    }
}