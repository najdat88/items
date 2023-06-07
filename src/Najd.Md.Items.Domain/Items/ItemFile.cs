using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    public class ItemFile : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        #endregion

        #region | Entity Constructure |
        public ItemFile()
        {
        }
        [Newtonsoft.Json.JsonConstructor]
        public ItemFile(Guid id)
    : base(id)
        {

        }
        #endregion

        #region | Entity Properties |
        [Column("item_id")]
        public Guid? Item_Id { get; set; }
        [Column("file")]
        public string File { get; set; }
        [Column("line_order")]
        public int? LineOrder { get; set; }
        #endregion

        #region | Entity Reference |
        [ForeignKey(nameof(Item_Id))]
        public virtual Item Item { get; set; }
        #endregion
    }
}

