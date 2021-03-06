// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractNumber
    {
        [TestMethod]
        public void ExtractNumber()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractNumber());
            Assert.AreEqual(null, new StringBuilder(".").ExtractNumber());
            Assert.AreEqual("1", new StringBuilder("1").ExtractNumber().ToString());
            Assert.AreEqual(".1", new StringBuilder(".1").ExtractNumber().ToString());
            Assert.AreEqual(".1", new StringBuilder(".1.1").ExtractNumber().ToString());
            Assert.AreEqual(".1D", new StringBuilder(".1D").ExtractNumber().ToString());
            Assert.AreEqual(".1", new StringBuilder("1.1").ExtractNumber(1).ToString());
            Assert.AreEqual(".1F", new StringBuilder("1.1F1").ExtractNumber(1, out endIndex).ToString());
            Assert.AreEqual(3, endIndex);
        }
    }
}