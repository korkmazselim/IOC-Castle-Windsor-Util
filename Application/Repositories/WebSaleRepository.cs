using Lets.Application.Abstract;
using Lets.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lets.Application.Repositories
{
    public class WebSaleRepository : ISaleRepository
    {
        public Sale CreateSale()
        {
            return new Sale() { SaleType = SaleType.Web};
        }

        public bool SaleValidation(Sale sale)
        {
            if (sale.SaleType == SaleType.Web)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void WhoIAm()
        {
            Console.Write("I am WebSaleRepository()");
        }
    }
}
