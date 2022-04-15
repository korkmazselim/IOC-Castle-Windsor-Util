using Application.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Repositories
{
    public class CashSaleRepository : ISaleRepository
    {
        public Sale CreateSale()
        {
            return new Sale() { SaleType = SaleType.Cash, Guest = new Guest() { Id = 999, GuestName = "Cash", GuestAddress = "Cash" } };
        }

        public bool SaleValidation(Sale sale)
        {
            if (sale.SaleType == SaleType.Cash)
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
            Console.WriteLine("I am CashSaleRepository()");
        }
    }
}
