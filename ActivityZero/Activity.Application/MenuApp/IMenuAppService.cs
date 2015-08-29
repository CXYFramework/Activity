using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Activity.MenuApp.Dto;

namespace Activity.MenuApp
{
    public interface IMenuAppService :IApplicationService
    {
        int InsertOrUpdateMenuAndGetId(MenuDto menuDto);
        

        IList<MenuDto> GetAllMenus();

        MenuDto GetMenuById(int Id);
    }
}
