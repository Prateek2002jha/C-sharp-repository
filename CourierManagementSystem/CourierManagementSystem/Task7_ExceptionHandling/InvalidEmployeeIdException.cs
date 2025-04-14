using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task7_ExceptionHandling
{

    // Custom exception for when an invalid employee ID is entered
   public  class InvalidEmployeeIdException : Exception
    {

        // Constructor that accepts a message and passes it to the base Exception class
        public InvalidEmployeeIdException(string message) : base(message) { }
    }
}
