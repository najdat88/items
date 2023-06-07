using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    public class ItemPrice : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        #endregion

        #region | Entity Constructure |
        public ItemPrice()
        {
        }
        [Newtonsoft.Json.JsonConstructor]
        public ItemPrice(Guid id)
    : base(id)
        {
            FromDate = DateTime.UtcNow;
        }
        #endregion

        #region | Entity Properties |
        [Column("item_id")]
        public Guid? Item_Id { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("agent_price")]
        public decimal AgentPrice { get; set; }
        [Column("cost")]
        public decimal Cost { get; set; }
        [Column("from_date")]
        public DateTime? FromDate { get; set; }
        [Column("to_date")]
        public DateTime? ToDate { get; set; }
        #endregion

        #region | Entity Reference |
        [ForeignKey(nameof(Item_Id))]
        public virtual Item Item { get; set; }
        #endregion
    }
}

