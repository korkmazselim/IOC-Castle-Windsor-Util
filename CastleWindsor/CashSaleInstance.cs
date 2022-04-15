using Application.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastleWindsor
{
    public class CashSaleInstance
    {
        ISaleRepository _ISaleRepository;
        public CashSaleInstance(ISaleRepository ISaleRepository)
        {
            _ISaleRepository = ISaleRepository;
        }
        public void WhoIAm() 
        {
            _ISaleRepository.WhoIAm();
        }
    }
}
