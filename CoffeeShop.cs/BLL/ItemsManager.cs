using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CoffeeShop.cs.Repository;
using CoffeeShop.cs.Model;


namespace CoffeeShop.cs.BLL
{
    public class ItemsManager
    {
        ItemsRepository _itemsRepository = new ItemsRepository();

            public bool IsNameExists(ItemModel itemModel)
            {
                return _itemsRepository.IsNameExists(itemModel);
            }
             public bool Additem(ItemModel itemModel)
            {
                return _itemsRepository.Additem(itemModel);
            }
            public DataTable Showitem()
            {
                return _itemsRepository.Showitem();
            }
            public bool Deleteitem(ItemModel itemModel)
            {
                return _itemsRepository.Deleteitem(itemModel);
            }
            public bool Modifyitem(ItemModel itemModel)
            {
                return _itemsRepository.Modifyitem(itemModel);
            }
            public DataTable Searchitem(ItemModel itemModel)
            {
                return _itemsRepository.Searchitem(itemModel);
            }

    }
}
