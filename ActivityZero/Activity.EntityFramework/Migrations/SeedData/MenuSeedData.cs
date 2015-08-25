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
            for (int i = 1; i <= 5; i++)
            {
               
                Menu menu = new Menu();
                menu.Text = "Parent" + i;


                menu.Parent = 0;
                _context.Menus.Add(menu);
                _context.SaveChanges();

                Menu menuChild = new Menu();

                menuChild.Parent = menu.Id;
                menuChild.Text = "Child" + i;
                _context.Menus.Add(menuChild);

            }
          



        }
    }
}