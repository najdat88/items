using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Najd.Md.Items
{
    /// <summary>
    /// <para>Sample Table API</para> 
    /// Best Practice:<br />
    /// 1- Set API URL route and must be pruler and lower case and no empty space<br />
    /// 2- Set action type HttpPost,HttpDelete,HttpGet.....<br />
    /// 3- Set set route for each action but for standart crud not required<br />
    /// </summary>
    [RemoteService]
    [Route("api/md/items")]
    public class ItemController : ItemsController, IItemAppService
    {
        private readonly IItemAppService _itemAppService;

        [HttpGet]
        public Task<ListResultDto<ItemDto>> GetListAsync(GetItemListDto input)
        {
            return _itemAppService.GetListAsync(input);
        }
        [HttpGet("{id:Guid}")]
        public Task<ItemDto> GetAsync(Guid id)
        {
            return _itemAppService.GetAsync(id);
        }
        [HttpDelete("{id:Guid}")]
        public async Task DeleteAsync(Guid Id)
        {
            await _itemAppService.DeleteAsync(Id);
        }
        [HttpPost]
        public async Task<ItemDto> InsertAsync(CreateItemDto input)
        {
            return await _itemAppService.InsertAsync(input);
        }
        [HttpPost]
        [Route("insert")]
        public async Task<ItemDto> InsertJsonAsync(string Values)
        {
            return await _itemAppService.InsertJsonAsync(Values);
        }

        [HttpPut("{id:Guid}")]
        public async Task<ItemDto> UpdateAsync(Guid id, UpdateItemDto input)
        {
            return await _itemAppService.UpdateAsync(id, input);
        }
        [HttpPut("update/{id:Guid}")]
        public async Task<ItemDto> UpdateJsonAsync(Guid id, string values)
        {
            return await _itemAppService.UpdateJsonAsync(id, values);
        }
    }
}
