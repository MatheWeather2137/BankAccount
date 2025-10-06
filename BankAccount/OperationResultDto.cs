using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class OperationResultDto
    {
        public bool Success;
        public string Message;

        public OperationResultDto(bool succes, string message)
        {
            this.Success = succes;
            this.Message = message;

        }
    }
}
