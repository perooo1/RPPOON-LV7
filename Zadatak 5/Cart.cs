using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class Cart
    {
        private List<IItem> cart;
        private IVisitor visitor;

        public Cart()
        {
            this.cart = new List<IItem>();
        }
        public Cart(IVisitor visitor)
        {
            this.cart = new List<IItem>();
            this.visitor = visitor;
        }

        public void AddToCart(IItem item)
        {
            this.cart.Add(item);
        }

        public void RemoveFromCart(IItem item)
        {
            this.cart.Remove(item);
        }

        public void ChangeVisitor(IVisitor visitor)
        {
            this.visitor = visitor;
        }

        public double Accept(IVisitor visitor)
        {
            double sum = 0;
            foreach (IItem item in this.cart)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }

    }
}
