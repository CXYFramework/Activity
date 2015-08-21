using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Activity.Entities;

namespace Activity.MenuApp.Dto
{
     [AutoMapFrom(typeof(Menu))]
    public class MenuDto : EntityDto
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int ParentId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
