using Lets.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lets.Application.Abstract
{
    public interface ISaleRepository
    {
        Sale CreateSale();
        bool SaleValidation(Sale sale);
        void WhoIAm();
    }
}
