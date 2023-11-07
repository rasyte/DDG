using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuckDuckGoSearchApp.Tests
{

    [TestClass] 
    public class Views_MainWindowTests
    {
        [STATestMethod]
        public void SearchCounter_isFiveOnLoad()
        {
            //Arrange
            var viewMainWindow = new MainWindow();
            Assert.IsTrue(viewMainWindow.SearchCount == 5, "SearchCount should start at 5" );
        }
    }
}
