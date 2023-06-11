using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.Application.Services;

namespace Najd.Md.Items
{
    public class ItemAppService : ItemsAppService, IItemAppService
    {
        private readonly IRepository<Item, Guid> _itemRepository;
        private readonly IRepository<ItemPrice, Guid> _itemPriceRepository;
        private readonly IGuidGenerator _guidGenerator;
        //private readonly ItemManager _itemManager;

        public ItemAppService(
            IRepository<Item, Guid> itemRepository,
            IRepository<ItemPrice, Guid> itemPriceRepository,
            IGuidGenerator guidGenerator
            )
        {
            _itemRepository = itemRepository;
            _itemPriceRepository = itemPriceRepository;
            _guidGenerator = guidGenerator;
        }

        public async Task<ItemDto> GetAsync(Guid id)
        {
            var item = await _itemRepository.GetAsync(id,includeDetails: true);
            await _itemRepository.EnsureCollectionLoadedAsync(item,x=>x.ItemPrices);
            await _itemRepository.EnsureCollectionLoadedAsync(item,x=>x.ItemCategories);
            //await _itemRepository.EnsureCollectionLoadedAsync(item,x=>x.ItemFiles);
            //await _itemRepository.EnsurePropertyLoadedAsync(item, x => x.ItemPrices);
            return ObjectMapper.Map<Item, ItemDto>(item);
        }

        public async Task<ListResultDto<ItemDto>> GetListAsync(GetItemListDto input)
        {
            string Filter_str = input.Filter != null ? input.Filter.ToLower() : "";

            //var items = await _itemRepository.GetListAsync(includeDetails: true);
            //var catalog_items = await _catalogAppService.GetCategoryItems(input.Category_Id.Value);
            var items = await _itemRepository.WithDetailsAsync(x => x.ItemCategories, x => x.ItemPrices);
            if (input.Category_Id != null)
            {
                var result = items.Where(x =>
                     //catalog_items.Contains(x.Id) &&  
                     (input.Filter == null || x.Name.ToLower().Contains(Filter_str))
                   ).OrderBy(x => x.Name).ToList();
                return new ListResultDto<ItemDto>(items: ObjectMapper.Map<List<Item>, List<ItemDto>>(result));
            }
            else
            {
                var result = items.Where(x => input.Filter == null || x.Name.ToLower().Contains(Filter_str)).OrderBy(x => x.Name).ToList();
                return new ListResultDto<ItemDto>(items: ObjectMapper.Map<List<Item>, List<ItemDto>>(result));
            }

        }
        public async Task<ItemDto> InsertAsync(CreateItemDto input)
        {
            Guid pk = _guidGenerator.Create();
            Item item = new Item(pk);
            item.Serial = 1;
            //item.ItemType_Id = new Guid("3f2cd216-26a1-4211-9d48-010641715350");
            if (input.Category_Id != null)
            {
                //item.ItemCategories = new List<ItemCategory>();
                //item.ItemCategories.Add(new ItemCategory(_guidGenerator.Create(), Category_Id, pk));
            }
            await _itemRepository.InsertAsync(item);

            return ObjectMapper.Map<Item, ItemDto>(item);
        }
        public async Task<ItemDto> UpdateAsync(Guid id, UpdateItemDto input)
        {
            var item = await _itemRepository.GetAsync(id);
            if (item == null)
                return null;

            item.Name = input.Name;

            return ObjectMapper.Map<Item, ItemDto>(item);
        }
        public async Task<ItemDto> InsertJsonAsync(string Values)
        {
            Guid? Category_Id = new Guid();
            Guid pk = _guidGenerator.Create();
            Item item = new Item(pk);
            JsonConvert.PopulateObject(Values, item);
            item.ItemType_Id = new Guid("3f2cd216-26a1-4211-9d48-010641715350");
            if (Category_Id != null)
            {
                //item.ItemCategories = new List<ItemCategory>();
                //item.ItemCategories.Add(new ItemCategory(_guidGenerator.Create(), Category_Id, pk));
            }
            await _itemRepository.InsertAsync(item);

            return ObjectMapper.Map<Item, ItemDto>(item);
        }
        public async Task<ItemDto> UpdateJsonAsync(Guid id, string values)
        {
            var item = await _itemRepository.GetAsync(id);
            if (item == null)
                return null;
            JsonConvert.PopulateObject(values, item);
            //await _itemRepository.UpdateAsync(item);

            return ObjectMapper.Map<Item, ItemDto>(item);
        }
        public async Task UpdateItemPayLoad(Guid Key, string Values)
        {
            var item = await _itemRepository.GetAsync(Key);
            //item.WorkflowProcessPayload = Values;
            await _itemRepository.UpdateAsync(item);
        }
        public async Task DeleteAsync(Guid Id)
        {
            var item = await _itemRepository.GetAsync(Id);
            await _itemRepository.DeleteAsync(item);
        }
        public async Task UpdateItemPrice(Guid Key, decimal Cost, decimal Price, decimal AgentPrice)
        {
            var _itemPriceQueryabl = await _itemPriceRepository.GetQueryableAsync();
            var query = _itemPriceQueryabl.Where(x=>x.Item_Id == Key && x.ToDate == null);
            var prices = query.ToList();
            if (prices != null)
            {
                if (prices.Count > 0)
                {
                    foreach (var item in prices)
                    {
                        item.ToDate = DateTime.UtcNow;
                    }
                    await _itemPriceRepository.UpdateManyAsync(prices);
                }
            }
            ItemPrice itemPrice = new ItemPrice
            {
                FromDate = DateTime.UtcNow,
                Item_Id = Key,
                Cost = Cost,
                Price = Price,
                AgentPrice = AgentPrice
            };
            await _itemPriceRepository.InsertAsync(itemPrice);
        }
    }
}