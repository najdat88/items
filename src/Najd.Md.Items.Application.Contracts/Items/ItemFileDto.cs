using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Najd.Md.Items
{
    public class ItemFileDto
    {
        public ItemFileDto()
        {
        }

        #region | Entity Properties |
        public Guid Id { get; set; }
        public Guid? Item_Id { get; set; }
        public string File { get; set; }
        public int? LineOrder { get; set; }
        #endregion
    }
}