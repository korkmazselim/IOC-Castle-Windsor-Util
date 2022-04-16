using Lets.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lets.Application
{
    public class WebSaleInstance:ISaleInstance
    {
        ISaleRepository _ISaleRepository;
        public WebSaleInstance(ISaleRepository ISaleRepository)
        {
            _ISaleRepository = ISaleRepository;
        }
        public void WhoIAm() 
        {
            _ISaleRepository.WhoIAm();
        }

    }
}
