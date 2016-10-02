using OfficeArrangament.Common;
using OfficeArrangament.Common.Enumerations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OfficeArrangement.Sandbox
{
    public partial class FormMain : Form
    {
        private Map _map;

        private readonly ToolStripMenuItem[] _brandMenuItems, _paletteMenuItems;

        public FormMain()
        {
            InitializeComponent();
            hoverImage.Image = Utility.GetEmbeddedImage("OfficeArrangement.Sandbox.Images.Hover.png",
                typeof(OfficeArrangement.Sandbox.Program));
            hoverImage.Visible = false;
            _map = new Map();
#if DEBUG
            string mapData =
                "FFFFFFFFFFFFFFFFFFFF\n" +
                "XTCXPPPPXTCXPPPPXTCX\n" +
                "XTCXPXXXXTCXPXXXXTCX\n" +
                "XTCXPXXFXTCXPXXFXTCX\n" +
                "FFFFFFFFFFFFFFFFFFFF\n" +
                "XTCXPPPPXTCXPPPPXTCX";
            _map.LoadData(mapData);
            RedrawMap();
#endif

            _brandMenuItems = new ToolStripMenuItem[]
            {
                hermanMillerToolStripMenuItem,
                wilkhahnToolStripMenuItem
            };

            _paletteMenuItems = new ToolStripMenuItem[]
            {
                lightToolStripMenuItem,
                darkToolStripMenuItem
            };
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadImage(fileDialog.FileName);
            }
        }

        private void LoadImage(string filePath)
        {
            string content = Utility.LoadTextFile(filePath);
            _map.LoadData(content);
            RedrawMap();
        }

        private void RedrawMap()
        {
            if (_map.IsMapLoaded)
            {
                Bitmap image = _map.Draw();
                pictureBoxMain.Image = image;
                pictureBoxMain.Size = image.Size;
            }
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_map.IsMapLoaded && _map.CheckIsFurniture(e.Location))
            {
                if (!hoverImage.Visible)
                {
                    hoverImage.Visible = true;
                }

                Point tileCorner = _map.GetTileTopCornerLocation(e.Location);
                // Correct the transparent image location with the current location of the map's image
                int x = pictureBoxMain.Left + tileCorner.X;
                int y = pictureBoxMain.Top + tileCorner.Y;
                Point actualTileCorner = new Point(x, y);
                hoverImage.Location = actualTileCorner;
            }
            else
            {
                hoverImage.Visible = false;
            }
        }

        private void pictureBoxMain_MouseLeave(object sender, EventArgs e)
        {
            hoverImage.Visible = false;
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (_map.IsMapLoaded && _map.CheckIsFurniture(e.Location))
            {
                _map.ToggleFurniture(e.Location);
                RedrawMap();
            }
        }

        private void hermanMillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBrand(Brand.HermanMiller);
        }

        private void wilkhahnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBrand(Brand.Wilkhahn);
        }

        private void ChangeBrand(Brand brand)
        {
            switch (brand)
            {
                case Brand.HermanMiller:
                    FormHelpers.CheckMenuItem(_brandMenuItems, 0);
                    break;
                case Brand.Wilkhahn:
                    FormHelpers.CheckMenuItem(_brandMenuItems, 1);
                    break;
                default:
                    throw new Exception($"Brand {brand} is not supported");
            }

            if (_map.IsMapLoaded)
            {
                _map.ChangeBrand(brand);
                RedrawMap();
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePalette(Palette.Light);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePalette(Palette.Dark);
        }

        private void ChangePalette(Palette palette)
        {
            switch (palette)
            {
                case Palette.Light:
                    FormHelpers.CheckMenuItem(_paletteMenuItems, 0);
                    break;
                case Palette.Dark:
                    FormHelpers.CheckMenuItem(_paletteMenuItems, 1);
                    break;
                default:
                    throw new Exception($"Brand {palette} is not supported");
            }

            if (_map.IsMapLoaded)
            {
                _map.ChangePalette(palette);
                RedrawMap();
            }
        }
    }
}
