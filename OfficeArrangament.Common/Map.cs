using OfficeArrangament.Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace OfficeArrangament.Common
{
    public class Map
    {
        private const int MaxMapSize = 50;
        private const int TileWidth = 42;

        private Dictionary<char, Type> _tileTypes = new Dictionary<char, Type>
        {
            { 'X', typeof(FreeSpace) },
            { 'T', typeof(Table) },
            { 'C', typeof(Chair) },
            { 'P', typeof(Pathway) },
            { 'F', typeof(Flowers) }
        };

        private int _mapWidth, _mapHeight;
        public int Width => _mapWidth;
        public int Height => _mapHeight;

        private Tile[,] _mapContent;
        public Tile[,] MapContent => _mapContent;

        public Bitmap _image { get; private set; }

        public Brand FurnitureBrand { get; set; }

        public Palette Palette { get; set; }

        public bool IsMapLoaded => _mapContent != null;

        public void LoadData(string content)
        {
            using (StringReader reader = new StringReader(content))
            {
                Type tileType;
                Tile[] row;
                List<Tile[]> map = new List<Tile[]>(MaxMapSize);
                int rowLengthCurrent;
                int columnIndex;
                bool isFirstRow = true;
                string line;

                // Rows
                _mapHeight = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    rowLengthCurrent = line.Length;
                    if (rowLengthCurrent > MaxMapSize)
                    {
                        throw new Exception("Unsupported map width");
                    }

                    // Check row length consistency of rows
                    if (isFirstRow)
                    {
                        _mapWidth = rowLengthCurrent;
                        isFirstRow = false;
                    }
                    else if (rowLengthCurrent != _mapWidth)
                    {
                        throw new Exception("Inconsistent row length");
                    }

                    row = new Tile[_mapWidth];
                    columnIndex = 0;

                    // Columns
                    foreach (char element in line)
                    {
                        if (!_tileTypes.TryGetValue(element, out tileType))
                        {
                            throw new Exception($"Unknown map element {element}");
                        }

                        if (tileType == typeof(FreeSpace) || tileType.IsSubclassOf(typeof(FreeSpace)))
                        {
                            row[columnIndex] = (Tile)Activator.CreateInstance(tileType, TileWidth);
                        }
                        else
                        {
                            row[columnIndex] = (Tile)Activator.CreateInstance(tileType);
                        }

                        columnIndex++;
                    }

                    map.Add(row);
                    _mapHeight++;

                    if (_mapHeight > MaxMapSize)
                    {
                        throw new Exception("Unsupported map height");
                    }
                }

                _mapContent = map.To2DArray();
            }
        }

        public void ChangeBrand(Brand brand)
        {
            CheckMapIsLoaded();

            ProcessTiles((tile, x, y) =>
            {
                if (tile is Furniture)
                {
                    ((Furniture)tile).Brand = brand;
                }
            });
        }

        public void ChangePalette(Palette palette)
        {
            CheckMapIsLoaded();

            ProcessTiles((tile, x, y) =>
            {
                if (tile is Interior)
                {
                    ((Interior)tile).Palette = palette;
                }
            });
        }

        public Bitmap Draw()
        {
            CheckMapIsLoaded();
            int width = TileWidth * _mapWidth;
            int height = TileWidth * _mapHeight;
            Bitmap image = new Bitmap(width, height);

            using (Graphics graph = Graphics.FromImage(image))
            {
                // Prefill with black to see if there are any errors
                Rectangle allSize = new Rectangle(0, 0, _mapWidth * TileWidth, _mapHeight * TileWidth);
                Brush brush = new SolidBrush(Color.Black);
                graph.FillRectangle(brush, allSize);

                ProcessTiles((tile, x, y) =>
                {
                    Bitmap tileImage = tile.Draw();
                    Point location = new Point(x * TileWidth, y * TileWidth);
                    graph.DrawImage(tileImage, location);
                });
            }

            _image = image;
            return image;
        }

        public Bitmap ToggleFurniture(int x, int y)
        {
            CheckMapIsLoaded();

            throw new NotImplementedException();
        }

        private void ProcessTiles(Action<Tile, int, int> action)
        {
            for (int x = 0; x < _mapWidth; x++)
            {
                for (int y = 0; y < _mapHeight; y++)
                {
                    // Screen coordinate system is opposite to the array indexing
                    action(_mapContent[y, x], x, y);
                }
            }
        }

        private void CheckMapIsLoaded()
        {
            if (_mapContent == null)
            {
                throw new Exception("Load the map first");
            }
        }
    }
}