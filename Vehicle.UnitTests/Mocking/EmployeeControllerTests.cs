﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Vehicle.Mocking;

namespace Vehicle.UnitTests.Mocking
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);

            controller.DeleteEmployee(1);

            storage.Verify(s => s.DeleteEmployee(1));
        }
    }
}
