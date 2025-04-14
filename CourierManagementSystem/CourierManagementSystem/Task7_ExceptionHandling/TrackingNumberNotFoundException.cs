using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task7_ExceptionHandling
{

    // Custom exception for when a tracking number is not found
    class TrackingNumberNotFoundException :Exception
    {


        // Constructor that accepts a message and passes it to the base Exception class
        public TrackingNumberNotFoundException(string message) : base(message) { }
    }
}
