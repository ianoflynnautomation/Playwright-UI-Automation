using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.One.UI.Settings.Configuration
{
    public sealed class WebSettings
    {
        public string BaseUrl { get; set; }
        public BrowserSettings Chrome { get; set; }
        public int ElementWaitTimeout { get; set; }
        public bool HeadLess { get; set; }
        public int SlowMo { get; set; }

    }
}
