using System;
using static System.Console;
using System.Diagnostics.Tracing;

namespace ceklink
{
    public class cek
    {
        public string link = default;
        public Uri validLink = default;
        public cek()
        {
            
        }
        public bool IsLink => Uri.TryCreate(link, UriKind.Absolute, out validLink);
    }
}
