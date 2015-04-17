using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedUITestProject1;

namespace IISDA_Test_cases
{
    [Microsoft.VisualStudio.TestTools.UITesting.CodedUITest]
    public class IISDATestCases
    {
        public IISDATestCases()
        {
        }
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Priority1"), Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code" from 
            // the shortcut menu and select one of the menu items.
            New_user newUser = new New_user();
            newUser.SetupTest();
            newUser.New_userSetUpTest();
            newUser.TeardownTest();
            /* }
             [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Priority1"), Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
             public void CodedUITestMethod2()
             {
                 // To generate code for this test, select "Generate Code" from 
                 // the shortcut menu and select one of the menu items.
                 Change_password Change_password = new Change_password();
                 Change_password.SetupTest();
                 Change_password.TheChangePasswordTest();
                 Change_password.TeardownTest();
             }
             [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Priority1"), Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
             public void CodedUITestMethod3()
             {
                 // To generate code for this test, select "Generate Code" from 
                 // the shortcut menu and select one of the menu items.
                 Request_For_Change_Of_Access Request_For_Change_Of_Access = new Request_For_Change_Of_Access();
                 Request_For_Change_Of_Access.SetupTest();
                 Request_For_Change_Of_Access.TheRequestForChangeOfAccessTest();
                 Request_For_Change_Of_Access.TeardownTest();
             }
             [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Priority1"), Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
             public void CodedUITestMethod4()
             {
                 // To generate code for this test, select "Generate Code" from 
                 // the shortcut menu and select one of the menu items.
                 New_Version_Of_The_Profile New_Version_Of_The_Profile = new New_Version_Of_The_Profile();
                 New_Version_Of_The_Profile.SetupTest();
                 New_Version_Of_The_Profile.TheNewVersionOfTheProfileTest();
                 New_Version_Of_The_Profile.TeardownTest();*/
        }
    }
}