using Lets.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lets.Application
{
    public class CashSaleInstance:ISaleInstance
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

    public interface ISaleInstance
    {
        void WhoIAm();
    }
}
