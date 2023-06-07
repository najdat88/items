using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    /// <summary>
    /// In Data Models, a Party can be a Person, an Organsation or a Group (of People or Organisations).
    /// A Party can then play a Role in an Event.
    /// This combination of Party and Role is a very flexible and powerful way of modelling complex situations.
    /// </summary>
    public class Item : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        public const int MaxCodeLength = 36;
        public const int MaxNameLength = 500;
        public const int MaxShortDescriptionLength = 255;
        #endregion

        #region | Entity Constructure |
        public Item()
        {
        }
        [Newtonsoft.Json.JsonConstructor]
        public Item(Guid id)
    : base(id)
        {

        }
        public Item(string Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;
        }
        #endregion

        #region | Entity Properties |
        [Column("code")]
        [MaxLength(MaxCodeLength)]
        public string Code { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }
        
        /// <summary>
        /// A stock keeping unit (SKU)
        /// </summary>
        //public DateTime? IntroductionDate { get; set; }

        /// <summary>
        /// 1 = Item
        /// 2 = Service
        /// 3 = Stock
        /// ////////////
        /// TM = Ticari Mal
        /// KK = Karma Koli
        /// DM = Depozitolu Mal
        /// SK = Sabit Kiymet
        /// SK = Hammadde
        /// YM = Yari mamul
        /// MM = Mamul
        /// TK = Tuketim Mali
        /// </summary>
        [Column("item_type_id")]
        public Guid ItemType_Id { get; set; }
        /// <summary>
        /// Based on Item Type
        /// </summary>
        #region | Master Data |
        [Column("attribute_set_id")]
        public Guid? AttributeSet_Id { get; set; }
        #endregion

        #region | General |
        #endregion

        #region | Purchasing |
        #endregion

        #region | Sales |
        #endregion

        #region | Stock / Inventory Data |
        #endregion

        #region | Planning Data |
        #endregion

        #region | Segmintations |
        #endregion

        #region | Remarks |
        [Column("short_description")]
        [MaxLength(MaxShortDescriptionLength)]
        public string ShortDescription { get; set; }
        [Column("description")]
        public string Description { get; set; }
        #endregion

        [Column("thumbnail")]
        public string Thumbnail { get; set; }

        [Column("multi_dimensional_base_product")]
        public bool MultiDimensionalBaseProduct { get; set; }
        /// <summary>
        /// Used for Multi-Dimensional Base Product
        /// variant product generated using product builder
        /// </summary>
        [Column("parent_id")]
        public Guid? Parent_Id { get; set; }
        [Column("item_object_id")]
        public Guid? ItemObject_Id { get; set; }

        [Column("workflow_process_payload")]
        public string WorkflowProcessPayload { get; set; }
        #endregion

        #region | Entity Reference |
        [ForeignKey(nameof(ItemType_Id))]
        public virtual ItemType ItemType { get; set; }
        [ForeignKey(nameof(ItemObject_Id))]
        public virtual ItemObject ItemObject { get; set; }

        [ForeignKey(nameof(AttributeSet_Id))]
        public AttributeSet AttributeSet { get; set; }
        public virtual ICollection<ItemFile> ItemFiles { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
        public virtual ICollection<ItemCategory> ItemCategories { get; set; }
        #endregion
    }
}
