using CourierManagementSystem.Task5_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Task6_Services
{
    interface ICourierAdminService
    {
        // Add new courier staff
        int AddCourierStaff(Employee obj);
    }
}
