using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CoffeeShop.cs.Repository;
using System.Threading.Tasks;
using CoffeeShop.cs.Model;

namespace CoffeeShop.cs.BLL
{
    public class OrderManagement
    {
        OrderRepository _orderRepository = new OrderRepository();

        public bool Addorder(OrderModel orderModel)
        {
            return _orderRepository.Addorder(orderModel );

        }
        public DataTable Showorder()
        {
            return _orderRepository.Showorder();

        }

        public bool Updateorder(OrderModel orderModel)
        {
            return _orderRepository.Updateorder( orderModel);

        }
        public bool Deleteorder(OrderModel orderModel)
        {
            return _orderRepository.Deleteorder( orderModel);

        }

        public DataTable Searchorder(OrderModel orderModel)
        {
            return _orderRepository.Searchorder( orderModel);

        }
        public DataTable NameComboBox()
        {
            return _orderRepository.NameComboBox();
        }
        public DataTable ItemNameComboBox()
        {
            return _orderRepository.ItemNameComboBox();
        }
    }
}
