using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Najd.Md.Items
{
    public class GetItemListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public Guid? Category_Id { get; set; }
        public Guid? ItemType_Id { get; set; }
        public Guid? ItemTypeCode { get; set; }

    }
}
