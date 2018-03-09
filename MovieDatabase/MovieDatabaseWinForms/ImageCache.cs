using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseWinForms {
    internal static class ImageCache {
        public static Image GetImage(string url) {
            lock (_bitmaps) {
                if (_bitmaps.ContainsKey(url))
                    return _bitmaps[url];
                var wc = new WebClient();
                using (var wcs = wc.OpenRead(url)) {
                    var bitmap = Image.FromStream(wcs);
                    _bitmaps[url] = bitmap;
                    return bitmap;
                }
            }
        }

        private static Dictionary<string, Image> _bitmaps = new Dictionary<string, Image>();
    }
}
