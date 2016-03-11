using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVeyorTest
{
    public class TestClass
    {
        private void MethodWithError() {
            List<int> list = new List<int>();
            list.Add(1);
        }

        public string TestMethod() {
            return "Hello, world!";
        }
    }
}
