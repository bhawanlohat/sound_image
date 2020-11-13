using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sound_image;
using UnitTest_image_n_sound.Images_UnitTest_Project;

namespace UnitTest_image_n_sound
{

    [TestClass]
    public class UnitTest1
    {
        private logicalclass logical_obj = new logicalclass();
        private int unit_result;


        [TestMethod]
        public void Test_spin_neg1()
        {
            int spin_unit_data = logicalclass.spin();
            Assert.AreNotEqual(0, spin_unit_data);
        }

        [TestMethod]
        public void test_spin_neg2()
        {
            int spin_unit_data = logicalclass.spin();
            Assert.AreNotEqual(7, spin_unit_data);
        }

        [TestMethod]
        public void test_spin_posi()
        {

            int spin_unit_data = logicalclass.spin();
            if (spin_unit_data >= 1 && spin_unit_data < 7)
            {
                unit_result = 1;
            }
            Assert.AreEqual(1, unit_result);
        }
    }
}
