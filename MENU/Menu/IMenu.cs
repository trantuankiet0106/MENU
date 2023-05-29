using MENU.Model;
using MENU.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MENU.Menu
{
    interface IMenu
    {
        List<View> GetListMenu();
        bool AddItem(AddItem request);
        bool DeleteItem(int nodeId);
        bool UpdateItem(int nodeId, AddItem request);
        List<View> GetAllMenu();
    }
}
