using System.Drawing;
using System.IO;
using System.Reflection;

namespace OfficeArrangament.Common
{
    public static class Utility
    {
        public static Bitmap GetEmbeddedImage(string resourceName)
        {
            Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            return new Bitmap(resource);
        }
    }
}
