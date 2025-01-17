﻿////////////////////////////////////////////////////////////////////////////////
// The MIT License (MIT)
//
// Copyright (c) 2019 Tim Stair
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
////////////////////////////////////////////////////////////////////////////////

using NUnit.Framework;
using Support.Util;

namespace UnitTest.Support.Util
{
    [TestFixture]
    internal class ParseUtilTest
    {
        [TestCase("1", 1, Result = true)]
        [TestCase("1.0", 1, Result = true)]
        [TestCase("1,0", 1, Result = true)]
        [TestCase("1.1", 1.1f, Result = true)]
        [TestCase("1,1", 1.1f, Result = true)]
        [TestCase("123.456", 123.456f, Result = true)]
        [TestCase("123,456", 123.456f, Result = true)]
        [TestCase("c", 0, Result = false)]
        public bool VerifyFloatParse(string sInput, float fExpectedValue)
        {
            float fValue;
            if (!ParseUtil.ParseFloat(sInput, out fValue))
            {
                return false;
            }
            Assert.AreEqual(fExpectedValue, fValue);
            return true;
        }

        [TestCase("1", 1, Result = true)]
        [TestCase("1.0", 1, Result = true)]
        [TestCase("1,0", 1, Result = true)]
        [TestCase("1.1", 1.1, Result = true)]
        [TestCase("1,1", 1.1, Result = true)]
        [TestCase("123.456", 123.456, Result = true)]
        [TestCase("123,456", 123.456, Result = true)]
        [TestCase("c", 0, Result = false)]
        public bool VerifyDecimalParse(string sInput, decimal dExpectedValue)
        {
            decimal dValue;
            if (!ParseUtil.ParseDecimal(sInput, out dValue))
            {
                return false;
            }
            Assert.AreEqual(dExpectedValue, dValue);
            return true;
        }
    }
}
