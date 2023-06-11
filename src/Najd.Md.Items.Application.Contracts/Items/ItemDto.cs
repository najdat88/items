using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Volo.Abp.Application.Dtos;

namespace Najd.Md.Items
{
    public class ItemDto
    {

        #region | Entity Constructure |
        public ItemDto()
        {
        }
        #endregion

        #region | Entity Properties |
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ItemType_Id { get; set; }

        #region | Remarks |
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        #endregion
        #region | Extra |
        // Set Price Based On Latest active item Price
        public decimal? Price
        {
            get
            {
                return (this.ItemPrices.Count > 0) ?
                    this.ItemPrices.OrderByDescending(x => x.FromDate).FirstOrDefault(x => x.ToDate == null || x.ToDate > DateTime.UtcNow).Price ?? null
                    : 0;
            }
        }
        public decimal? Cost
        {
            get
            {
                return (this.ItemPrices.Count > 0) ?
                    this.ItemPrices.OrderByDescending(x => x.FromDate).FirstOrDefault(x => x.ToDate == null || x.ToDate > DateTime.UtcNow).Cost ?? null
                    : 0;
            }
        }
        public decimal? AgentPrice
        {
            get
            {
                return (this.ItemPrices.Count > 0) ?
                    this.ItemPrices.OrderByDescending(x => x.FromDate).FirstOrDefault(x => x.ToDate == null || x.ToDate > DateTime.UtcNow).AgentPrice ?? null
                    : 0;
            }
        }
        
        #endregion
        #endregion

        //public virtual ICollection<ItemFileDto> ItemFiles { get; set; }
        public virtual ICollection<ItemPriceDto> ItemPrices { get; set; }
        public virtual ICollection<ItemCategoryDto> ItemCategories { get; set; }
    }

    public class CreateItemDto
    {

        #region | Entity Constructure |
        public CreateItemDto()
        {
        }
        #endregion

        #region | Entity Properties |
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ItemType_Id { get; set; }
        public Guid? Category_Id { get; set; }

        #region | Remarks |
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        #endregion
        #endregion

    }
    public class UpdateItemDto
    {

        #region | Entity Constructure |
        public UpdateItemDto()
        {
        }
        #endregion

        #region | Entity Properties |
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ItemType_Id { get; set; }

        #region | Remarks |
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        #endregion
        #endregion

    }
}