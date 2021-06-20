using CompanyPaymentEx.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPaymentEx.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public void ProcessContract(Contract contract, int months, IOnlinePaymentService onlinePaymentService)
        {

        }
    }
}
