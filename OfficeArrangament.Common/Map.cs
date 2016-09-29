using OfficeArrangament.Common.Enumerations;
using OfficeArrangament.Common.Interior;
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

        private readonly int _mapWidth, _mapHeight;

        private readonly Tile[,] _mapContent;
        public Tile[,] MapContent => _mapContent;

        public Brand FurnitureBrand { get; set; }

        public Palette Palette { get; set; }

        public Map(int mapWidth, int mapHeight)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            _mapContent = new Tile[mapWidth, mapHeight];
        }

        public void LoadData(string content)
        {
            using (StringReader reader = new StringReader(content))
            {
                int row = 0, col = 0;
                string line;
                Type tileType;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length > MaxMapSize)
                    {
                        throw new Exception("Unsupported map width");
                    }

                    foreach (char element in line)
                    {
                        if (!_tileTypes.TryGetValue(element, out tileType))
                        {
                            throw new Exception($"Unknown map element {element}");
                        }

                        object[] args = null;
                        if (tileType.IsSubclassOf(typeof(FreeSpace))
                        {
                            args = new object[] { TileWidth };
                        }
                        _mapContent[row, col] = (Tile)Activator.CreateInstance(tileType, args);
                    }
                }
            }
        }

        public void ChangeBrand(Brand brand)
        {

        }

        public void ChangePalette(Palette palette)
        {

        }

        public Bitmap Draw()
        {
            throw new NotImplementedException();
        }
    }
}