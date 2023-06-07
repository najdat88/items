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
    [Route("api/master-data/items")]
    public class ItemController : ItemsController, IItemAppService
    {
        private readonly IItemAppService _itemAppService;

        public ItemController(IItemAppService itemAppService)
        {
            _itemAppService = itemAppService;
        }

        [HttpDelete("{id:Guid}")]
        public async Task Delete(Guid Id)
        {
            await _itemAppService.Delete(Id);
        }

        [HttpGet("{id:Guid}")]
        public async Task<ItemDto> GetAsync(Guid id)
        {
            return await _itemAppService.GetAsync(id);
        }
        [HttpGet]
        [Route("list")]
        public async Task<List<ItemDto>> GetListAsync(GetItemListDto input)
        {
            return await _itemAppService.GetListAsync(input);
        }

        [HttpPost]
        [Route("insert")]
        public async Task<ItemDto> Insert(string Values,Guid? Category_Id)
        {
            return await _itemAppService.Insert(Values, Category_Id);
        }

        [HttpPut]
        [Route("update")]
        public async Task<ItemDto> Update(Guid Key, string Values)
        {
            return await _itemAppService.Update(Key, Values);
        }

        [HttpPut]
        [Route("update-item-price")]
        public async Task UpdateItemPrice(Guid Key, decimal Cost, decimal Price, decimal AgentPrice)
        {
            await _itemAppService.UpdateItemPrice(Key, Cost,Price, AgentPrice);
        }
        [HttpPut]
        [Route("update-item-payLoad")]
        public async Task UpdateItemPayLoad(Guid Key, string Values)
        {
            await _itemAppService.UpdateItemPayLoad(Key, Values);
        }
    }
}
