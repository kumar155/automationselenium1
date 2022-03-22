using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework.Test
{
    class ShareSkills
    {
        [TestFixture]
        class User : Global.Base
        {

            [Test]
            public void AddShareSkill()
            {
                test = extent.StartTest("AddShareSkill");
                ShareSkill sk = new ShareSkill();
                sk.EnterShareSkill();
            }
        }
    }
}
