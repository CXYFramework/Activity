using Activity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity.Entities;

namespace Activity.Migrations.SeedData
{
    public class MenuBuilder
    {
        private readonly ActivityDbContext _context;

        public MenuBuilder(ActivityDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            CreatMenu();
        }

        private void CreatMenu()
        {
            Menu menu = new Menu();

            menu.Name = "Parent1";
            menu.DisplayName = "Parent1";
            menu.ParentId = 0;
            _context.Menus.Add(menu);

            int menuId = _context.SaveChanges();
            menu.Name = "Parent1";
            menu.DisplayName = "Parent1";
            menu.ParentId = 0;
            _context.Menus.Add(new Menu { Name = "Child1", DisplayName = "Child1", ParentId = menuId });
           
            
            _context.SaveChanges();

        }
    }
}