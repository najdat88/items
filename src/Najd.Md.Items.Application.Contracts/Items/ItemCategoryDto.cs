using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Najd.Md.Items
{
    public class ItemCategoryDto
    {
        public ItemCategoryDto()
        {
        }

        #region | Entity Properties |
        public Guid Id { get; set; }
        public Guid Category_Id { get; set; }
        public Guid Item_Id { get; set; }
        #endregion
    }
}