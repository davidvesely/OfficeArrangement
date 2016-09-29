using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Test.VisualVerification;
using System.Drawing;
using OfficeArrangament.Common;

namespace OfficeArrangement.Tests
{
    [TestClass]
    public class ElementsTests
    {
        private Bitmap GetColorFilledBitmap(int width, Color color)
        {
            Rectangle rectangle = new Rectangle(0, 0, width, width);
            Bitmap bitmap = new Bitmap(250, 250);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Brush brush = new SolidBrush(Color.White);
                graphics.FillRectangle(brush, rectangle);
            }
            return bitmap;
        }

        private bool AreEqualImages(Snapshot expected, Snapshot actual, ColorDifference colorDifference = null)
        {
            if (colorDifference == null)
            {
                colorDifference = new ColorDifference();
            }

            // Difference should be black image with no tollerance
            Snapshot difference = actual.CompareTo(expected);
            SnapshotVerifier verifier = new SnapshotColorVerifier(Color.Black, colorDifference);
            return verifier.Verify(difference) != VerificationResult.Fail;
        }

        [TestMethod]
        public void FreeSpace_filled_with_white()
        {
            int width = 250;
            Bitmap expectedBmp = GetColorFilledBitmap(width, Color.White);
            Snapshot expected = Snapshot.FromBitmap(expectedBmp);

            // Act
            FreeSpace freeSpace = new FreeSpace(width);
            Bitmap actualBmp = freeSpace.Draw();
            Snapshot actual = Snapshot.FromBitmap(actualBmp);

            // Assert
            Assert.IsTrue(AreEqualImages(expected, actual), "Expected image is not white");
        }
    }
}
