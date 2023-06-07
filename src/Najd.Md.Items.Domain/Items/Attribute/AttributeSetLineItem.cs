using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    /// <summary>
    ///     The PRODUCT FEATURE entity may have many subtypes and will invariably
    ///    be customized for the enterprise, depending on the types of features that are
    ///    applicable.Subtypes of PRODUCT FEATURE may include the following:
    ///    
    ///     • PRODUCT QUALITY classifies the product by value such as "grade A" or
    ///    "grade B." For service products, such as a consultant, this may represent
    ///     "expert" or "junior."
    ///     • COLOR describes the color(s) of the good. A good may have more than
    ///    one COLOR option, but a different color may also denote that it is a separate good.
    ///    • DIMENSION describes the various numeric descriptions of the good such
    ///     as "8^-inch width," "11-inch length," or "10 pound." The DIMENSION is
    ///     related to UNIT OF MEASURE, which has a description attribute that
    ///    defines how the feature is being measured. The unit of measure may
    ///    determine how the product can be inventoried and sold, such as by the
    ///     "box" or "each." For service products, the unit of measure values may be
    ///    "hours" or "days."
    ///     • SIZE specifies how large or small a product is in more general terms than
    ///    dimension such as "extra large," "large," "medium," or "small." This feature could be useful in the garment industry.
    ///    • BRAND NAME describes the marketing name tied to the good, such as
    ///     "Buick" for a General Motors vehicle. Note that the brand name may be
    ///    different from the manufacturer's name.
    ///     - SOFTWARE FEATURE allows additional software to be added to products or allows certain software settings to be specified for a product. For
    ///    instance, software dollar limits could be set for products that are based
    ///    on usage, such as meters.Another example could be the setting of software preferences for a software package or hardware purchase.
    ///    • HARDWARE FEATURES allow for the specification of certain components that are included or that may be added to a product—for example,
    ///    a cover for a printer.
    ///    • A BILLING FEATURE is an example of a product feature that specifies
    ///    the standard types of terms that may be associated with a product, such
    ///    as recording that an Internet access service may be available with either
    ///    monthly or quarterly billing.
    /// </summary>
    public class AttributeSetLineItem : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        #endregion

        #region | Entity Constructure |
        public AttributeSetLineItem()
        {
        }
        #endregion

        #region | Entity Properties |
        /// <summary>
        /// (Required) A unique identifier for internal use. The Attribute Code must begin with a letter, but can include a combination of 
        /// lowercase letters (a-z) and numbers (0-9). The code must be less than thirty characters in length and cannot include any special 
        /// characters or spaces, although an underscore (_) can be used to indicate a space.
        /// </summary>
        [Column("attribute_set_Id")]
        public Guid? AttributeSet_Id { get; set; }
        [Column("attribute_id")]
        public Guid? Attribute_Id { get; set; }
        [Column("default_value")]
        public string DefaultValue { get; set; }
        [Column("required")]
        public bool Required { get; set; }
        //public bool UseInFilterOptions { get; set; }
        //public bool UseInSearch { get; set; }
        //public bool ComparableOnStorefront { get; set; }
        [Column("line_order")]
        public int? LineOrder { get; set; }
        #endregion

        #region | Entity Reference |
        [ForeignKey(nameof(Attribute_Id))]
        public Attribute Attribute { get; set; }
        [ForeignKey(nameof(AttributeSet_Id))]
        public AttributeSet AttributeSet { get; set; }
        #endregion
    }
}
