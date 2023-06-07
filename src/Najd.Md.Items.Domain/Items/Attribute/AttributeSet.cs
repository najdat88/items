using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    /// <summary>
    /// Variable product is the product type that lets you sell with different variations.
    //  Attributes are extra information about the product.
    /// Variations are the combination of choices that the customer has when purchasing the product.
    /// </summary>
    public class AttributeSet : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        public const int MaxNameLength = 500;
        #endregion

        #region | Entity Constructure |
        public AttributeSet()
        {
        }
        #endregion

        #region | Entity Properties |
        [Column("name")]
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }
        [Column("line_order")]
        public int? LineOrder { get; set; }

        #endregion

        #region | Entity Reference |
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<AttributeSetLineItem> AttributeSetLineItems { get; set; }
        #endregion
    }
}
