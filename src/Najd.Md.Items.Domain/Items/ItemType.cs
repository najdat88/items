using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    public class ItemType : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |

        public const int MaxCodeLength = 36;
        public const int MaxNameLength = 36;
        #endregion

        #region | Entity Constructure |
        public ItemType()
        {
        }
        [Newtonsoft.Json.JsonConstructor]
        public ItemType(Guid id)
    : base(id)
        {

        }
        public ItemType(string code,string name,int? lineOrder = null)
        {
            Code = code;
            Name = name;
            LineOrder = lineOrder;
        }
        #endregion

        #region | Entity Properties |

        [Column("code")]
        [MaxLength(MaxCodeLength)]
        public string Code { get; set; }
        [Column("name")]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }
        [Column("line_order")]
        public int? LineOrder { get; set; }

        #endregion

        #region | Entity Reference |

        public virtual ICollection<Item> Items { get; set; }
        #endregion
    }
}
