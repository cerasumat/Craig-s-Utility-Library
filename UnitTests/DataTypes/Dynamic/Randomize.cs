﻿/*
Copyright (c) 2014 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

using System;
using Utilities.DataTypes;
using Xunit;

namespace UnitTests.DataTypes.Dynamic
{
    public class Randomize
    {
        [Fact]
        public void Loaded()
        {
            dynamic Object = new Utilities.DataTypes.Dynamo(new { A = 1, B = 2.0f, C = "ASDF" });
            Assert.True(Object.ContainsKey("Randomize"));
            Assert.Equal(typeof(Action), Object["Randomize"].GetType());
            TestClass Temp = Object;
            Object.Randomize();
            Assert.NotEqual(Temp.A, Object.A);
            Assert.NotEqual(Temp.B, Object.B);
            Assert.NotEqual(Temp.C, Object.C);
        }

        public class TestClass
        {
            public int A { get; set; }
            public float B { get; set; }
            public string C { get; set; }
        }
    }
}
