using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace OfficeArrangament.Common
{
    public static class Utility
    {
        public static Bitmap GetEmbeddedImage(string resourceName)
        {
            Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            return new Bitmap(resource);
        }

        public static Bitmap GetEmbeddedImage(string resourceName, Type type)
        {
            Stream resource = Assembly.GetAssembly(type).GetManifestResourceStream(resourceName);
            return new Bitmap(resource);
        }

        /// <summary>
        /// Converts source to 2D array.
        /// </summary>
        /// <typeparam name="T">
        /// The type of item that must exist in the source.
        /// </typeparam>
        /// <param name="source">
        /// The source to convert.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if source is null.
        /// </exception>
        /// <returns>
        /// The 2D array of source items.
        /// </returns>
        public static T[,] To2DArray<T>(this List<T[]> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            int max = source.Select(l => l).Max(l => l.Count());

            var result = new T[source.Count, max];

            for (int i = 0; i < source.Count; i++)
            {
                for (int j = 0; j < source[i].Count(); j++)
                {
                    result[i, j] = source[i][j];
                }
            }

            return result;
        }

        /// <summary>
        /// Read a file and check if it is in text format
        /// </summary>
        /// <param name="path">File's location</param>
        /// <returns>File's content</returns>
        public static string LoadTextFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"File {path} is not found");
            }

            string content = File.ReadAllText(path);

            if (IsBinary(content))
            {
                throw new Exception($"File {path} is binary, please provide map in text file!");
            }

            return content;
        }

        private static bool IsBinary(string content)
        {
            return content.Any(ch => char.IsControl(ch) && ch != '\r' && ch != '\n');
        }
    }
}
