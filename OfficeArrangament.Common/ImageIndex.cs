namespace OfficeArrangament.Common
{
    internal class ImageIndex
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public ImageIndex(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
