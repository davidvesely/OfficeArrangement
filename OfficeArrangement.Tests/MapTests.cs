using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeArrangament.Common;
using System.Text;

namespace OfficeArrangement.Tests
{
    [TestClass]
    public class MapTests
    {
        private string PopulateContent(string row, int desiredRowCount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < desiredRowCount; i++)
            {
                if (i < desiredRowCount - 1)
                {
                    sb.AppendLine(row);
                }
                else // Last row without unneeded line break
                {
                    sb.Append(row);
                }
            }
            return sb.ToString();
        }

        [TestMethod]
        public void load_map_successful()
        {
            // Arrange
            string content =
                "FFTTCC\n" +
                "PPFFXX\n" +
                "TCPFXT";

            // Act
            Map map = new Map();
            map.LoadData(content);

            // Assert
            Assert.IsTrue(map.IsMapLoaded);
        }

        [TestMethod]
        public void load_map_wrong_width()
        {
            // Arrange
            string row = new string('F', 51);
            string content = PopulateContent(row, 5);

            // Act
            try
            {
                Map map = new Map();
                map.LoadData(content);
                Assert.Fail("Exception for wrong width should be thrown");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void load_map_wrong_height()
        {
            // Arrange
            string row = new string('F', 5);
            string content = PopulateContent(row, 51);

            // Act
            try
            {
                Map map = new Map();
                map.LoadData(content);
                Assert.Fail("Exception for wrong height should be thrown");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void load_map_error_inconsistent_size()
        {
            // Arrange
            string content =
                "FFTTCC\n" +
                "PPFFXXFF\n" +
                "TCPFX";

            // Act
            try
            {
                Map map = new Map();
                map.LoadData(content);
                Assert.Fail("Exception for inconsistent size should be thrown");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void load_map_error_unknown_element()
        {
            // Arrange
            string content =
                "FFTTCCQAS\n" +
                "PPFFXXF\n" +
                "TCPFX";

            // Act
            try
            {
                Map map = new Map();
                map.LoadData(content);
                Assert.Fail("Exception for inconsistent size should be thrown");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void load_map_correct_tiles()
        {
            // Arrange
            string content = "XTCPF";

            // Act
            Map map = new Map();
            map.LoadData(content);

            // Assert
            Assert.AreEqual(typeof(FreeSpace), map.MapContent[0, 0].GetType());
            Assert.AreEqual(typeof(Table), map.MapContent[0, 1].GetType());
            Assert.AreEqual(typeof(Chair), map.MapContent[0, 2].GetType());
            Assert.AreEqual(typeof(Pathway), map.MapContent[0, 3].GetType());
            Assert.AreEqual(typeof(Flowers), map.MapContent[0, 4].GetType());
        }

        [TestMethod]
        public void load_map_width_height()
        {
            // Arrange
            string content =
                "FFTTCC\n" +
                "PPFFXX\n" +
                "TCPFXT";

            // Act
            Map map = new Map();
            map.LoadData(content);

            // Assert
            Assert.AreEqual(6, map.Width);
            Assert.AreEqual(3, map.Height);
        }
    }
}
