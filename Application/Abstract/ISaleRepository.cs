using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Abstract
{
    public interface ISaleRepository
    {
        Sale CreateSale();
        bool SaleValidation(Sale sale);
        void WhoIAm();
    }
}
