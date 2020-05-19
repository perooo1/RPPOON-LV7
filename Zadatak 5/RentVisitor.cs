using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class RentVisitor : IVisitor
    {

        ///////////////////////////////////// za šesti zadatak:
        /*
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return double.NaN;
            else
                return 0.1 * DVDItem.Price;
        }
        */

        public double Visit(VHS VHSItem)
        {
            return 0.1 * VHSItem.Price;
        }

        public double Visit(Book book)
        {
            return 0.1 * book.Price;
        }

        ///////////////////////////////////// za sedmi zadatak:
        
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return DVDItem.Price;
            else
                return 0.1 * DVDItem.Price;
        }
        
    }
}
