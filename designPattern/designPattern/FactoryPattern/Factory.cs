using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.FactoryPattern
{

    //Creator
    public abstract class SalesFactory
    {
        public abstract ISale GetSale();
    }

    //Concrete Creator StoreSale
    public class StoreSaleFactory : SalesFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
    
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    //Concrete Creator InternetSale

    public class InternetSalesFactory : SalesFactory
    {
        private decimal _discount;

        public InternetSalesFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    //Concrete Product StoreSale
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }   

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en Tienda tiene un total de {total + _extra}");
        }
    }

    //Concrete Creator Internet Sale



    //Concrete Product Internet Sale



    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            _discount = discount;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine ($"La venta por INTERNET tiene un total de {total - _discount}");
        }
    }


    //Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
