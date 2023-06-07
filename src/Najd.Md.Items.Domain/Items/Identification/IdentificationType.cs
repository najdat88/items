using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;


namespace Najd.Md.Items
{
    /// <summary>
    /// Goods may have various ids that are used as a standard means of identifying the goods.
    /// SKU,UPCA,Part Number,.......
    /// </summary>
    public class IdentificationType : FullAuditedEntity<Guid>
    {
        #region | Entity Attribute |
        #endregion

        #region | Entity Constructure |
        public IdentificationType()
        {
        }
        #endregion

        #region | Entity Properties |
        
        #endregion

        #region | Entity Reference |
        #endregion
    }
}
