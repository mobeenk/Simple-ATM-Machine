using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    public static class balanceMangment
    {
        public static double balance { get; set; } = 2500;
        public static void deposit(double amount)
        {
            balance += amount;
        }
        public static void withdraw(double amount)
        {
            balance -= amount;
        }

    }
}
