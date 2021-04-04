﻿using NUnit.Framework;
using Quadratic_Equation_Plot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTests
{
    public class PolinomTestFixture
    {
        [Test]
        public void Roots_LinearPolinom_ReturnsSingleRoot()
        {
            // Arrange
            var polinom = new List<double> { 0, 1 };

            // Act
            var roots = Polinom.Roots(polinom);

            // Assert
            Assert.AreEqual(1, roots.Length, "Should have exactly one root");

        }
    }
}
