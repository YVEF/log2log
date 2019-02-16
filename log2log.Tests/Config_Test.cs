using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Tests
{
    [TestClass]
    public class Config_Test
    {
        [TestMethod]
        public void Method1()
        {
            var conf = log2log.Configuration.LogConfigHelper.GetConfigFromDomain();
            Assert.IsNotNull(conf);
        }
    }
}
