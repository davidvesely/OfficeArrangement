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
                Brush brush = new SolidBrush(color);
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

        [TestMethod]
        public void Light_Flowers_filled_with_Purple()
        {
            int width = 250;
            Bitmap expectedBmp = GetColorFilledBitmap(width, Color.Purple);
            Snapshot expected = Snapshot.FromBitmap(expectedBmp);

            // Act
            Flowers flowers = new Flowers(width);
            flowers.Palette = OfficeArrangament.Common.Enumerations.Palette.Light;
            Bitmap actualBmp = flowers.Draw();
            Snapshot actual = Snapshot.FromBitmap(actualBmp);

            // Assert
            Assert.IsTrue(AreEqualImages(expected, actual), "Expected image is not purple");
        }

        [TestMethod]
        public void Dark_Flowers_filled_with_Green()
        {
            int width = 250;
            Bitmap expectedBmp = GetColorFilledBitmap(width, Color.Green);
            Snapshot expected = Snapshot.FromBitmap(expectedBmp);

            // Act
            Flowers flowers = new Flowers(width);
            flowers.Palette = OfficeArrangament.Common.Enumerations.Palette.Dark;
            Bitmap actualBmp = flowers.Draw();
            Snapshot actual = Snapshot.FromBitmap(actualBmp);

            // Assert
            Assert.IsTrue(AreEqualImages(expected, actual), "Expected image is not green");
        }

        [TestMethod]
        public void Light_Pathway_filled_with_Gray()
        {
            int width = 250;
            Bitmap expectedBmp = GetColorFilledBitmap(width, Color.Gray);
            Snapshot expected = Snapshot.FromBitmap(expectedBmp);

            // Act
            Pathway flowers = new Pathway(width);
            flowers.Palette = OfficeArrangament.Common.Enumerations.Palette.Light;
            Bitmap actualBmp = flowers.Draw();
            Snapshot actual = Snapshot.FromBitmap(actualBmp);

            // Assert
            Assert.IsTrue(AreEqualImages(expected, actual), "Expected image is not gray");
        }

        [TestMethod]
        public void Dark_Pathway_filled_with_Brown()
        {
            int width = 250;
            Bitmap expectedBmp = GetColorFilledBitmap(width, Color.Brown);
            Snapshot expected = Snapshot.FromBitmap(expectedBmp);

            // Act
            Pathway flowers = new Pathway(width);
            flowers.Palette = OfficeArrangament.Common.Enumerations.Palette.Dark;
            Bitmap actualBmp = flowers.Draw();
            Snapshot actual = Snapshot.FromBitmap(actualBmp);

            // Assert
            Assert.IsTrue(AreEqualImages(expected, actual), "Expected image is not brown");
        }
    }
}
