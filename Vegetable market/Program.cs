using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vegetable_market.Controllers;
using Vegetable_market.Models;
using Vegetable_market.View;

namespace Vegetable_market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MarketActionController controller = new MarketActionController();
            controller.Initialize();
        }
    }
}
