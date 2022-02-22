using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.UnitTests
{
    [TestFixture]
    public class StartMenuTests
    {
        [Test]
        // MethodName_Scenario_ExpectedBehaviour
        public void CreateMenu_WhenCalled_ReturnsFalse()
        {
            var newVehicle = new StartMenu();

            //var result = newVehicle.CreateMenu();
        }
    }
}
