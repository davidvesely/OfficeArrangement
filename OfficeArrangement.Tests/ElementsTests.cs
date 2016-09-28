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
        //private 

        [TestMethod]
        public void FreeSpace_filled_with_white()
        {
            int width = 250;
            Rectangle rectangle = new Rectangle(0, 0, width, width);
            Bitmap expectedBmp = new Bitmap(250, 250);
            using (Graphics graphics = Graphics.FromImage(expectedBmp))
            {
                Brush brush = new SolidBrush(Color.White);
                graphics.FillRectangle(brush, rectangle);
            }
            Snapshot expected = Snapshot.FromBitmap(expectedBmp);

            // Act
            FreeSpace freeSpace = new FreeSpace();
            Bitmap actualBmp = freeSpace.Draw(width);
            Snapshot actual = Snapshot.FromBitmap(actualBmp);

            // Assert
            Snapshot difference = actual.CompareTo(expected);
            // Difference should be black image with no tollerance
            SnapshotVerifier verifier = new SnapshotColorVerifier(Color.Black, new ColorDifference());
            if (verifier.Verify(difference) == VerificationResult.Fail)
            {
                Assert.Fail("Expected image is not white");
            }
        }
    }
}
