using designPattern.FactoryPattern;
using System;

namespace designPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo un objeto del hijo de la clase abstracta SalesFactory
            SalesFactory storeSaleFactory = new StoreSaleFactory(10);
            SalesFactory internetSaleFactory = new InternetSalesFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);


            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);

        }
    }
}