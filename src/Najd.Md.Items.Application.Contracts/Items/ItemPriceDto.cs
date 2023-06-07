using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Najd.Md.Items
{
    public class ItemPriceDto
    {
        public ItemPriceDto()
        {
        }

        #region | Entity Properties |
        public Guid Id { get; set; }
        public Guid? Item_Id { get; set; }
        public decimal? Price { get; set; }
        public decimal? AgentPrice { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        #endregion
    }
}