using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    public class ItemCategory : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        #endregion

        #region | Entity Constructure |
        public ItemCategory()
        {
        }
        [Newtonsoft.Json.JsonConstructor]
        public ItemCategory(Guid id)
    : base(id)
        {

        }
        public ItemCategory(Guid id,Guid? category_Id,Guid? item_Id)
    : base(id)
        {
            Category_Id = category_Id;
            Item_Id = item_Id;
        }
        #endregion

        #region | Entity Properties |
        [Column("category_id")]
        public Guid? Category_Id { get; set; }
        [Column("item_id")]
        public Guid? Item_Id { get; set; }
        #endregion

        #region | Entity Reference |
        [ForeignKey(nameof(Item_Id))]
        public virtual Item Item { get; set; }
        #endregion
    }
}
