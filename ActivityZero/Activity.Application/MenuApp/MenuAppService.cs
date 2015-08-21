using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Activity.Entities ;
using AutoMapper;
using Activity.MenuApp.Dto;
namespace Activity.MenuApp
{
    public class MenuAppService : ApplicationService, IMenuAppService
    {
        IRepository<Menu> _menuRepository;
        
        public MenuAppService(IRepository<Menu> _menuRepository)
        {
            this._menuRepository = _menuRepository;
 
        }
        public int InsertOrUpdateMenuAndGetId(Dto.MenuDto menuDto)
        {
            return _menuRepository.InsertOrUpdateAndGetId(Mapper.Map<Menu>(menuDto));
        }

        public IList<MenuDto> GetAllMenus()
        {
            return Mapper.Map<IList<MenuDto>>(_menuRepository.GetAllList());
        }

        public Dto.MenuDto GetMenuById(int Id)
        {
            return Mapper.Map <MenuDto> (_menuRepository.Get(Id));
        }
       
    }
}
