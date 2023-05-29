using MENU.Model;
using MENU.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MENU.Menu
{
    public class Menu : IMenu
    {
        private readonly MenuDbContext _context;
        public bool AddItem(AddItem request)
        {
            MenuItems item = new MenuItems()
            {
                Name = request.ItemName,
                ParentId = request.ParentId
            };
            _context.MenuItems.Add(item);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteItem(int nodeId)
        {
            throw new NotImplementedException();
        }

        public List<View> GetAllMenu()
        {
            throw new NotImplementedException();
        }

        public List<View> GetListMenu()
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(int nodeId, AddItem request)
        {
            throw new NotImplementedException();
        }
    }
}
