using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Common;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;


namespace SORA_Class
{
    class Report
    {
        private FontConverter fontType;
        private StreamReader printFile;
        private float marginLeft;
        private float marginRight;
        private float marginTop;
        private float marginBottom;

        public Report(FontConverter fontType, string path, float marginLeft, float marginRight, float marginTop, float marginBottom)
        {
            FontType = fontType;
            PrintFile = new StreamReader(path);
            MarginLeft = marginLeft;
            MarginRight = marginRight;
            MarginTop = marginTop;
            MarginBottom = marginBottom;
        }

        public FontConverter FontType { get => fontType; set => fontType = value; }
        public StreamReader PrintFile { get => printFile; set => printFile = value; }
        public float MarginLeft { get => marginLeft; set => marginLeft = value; }
        public float MarginRight { get => marginRight; set => marginRight = value; }
        public float MarginTop { get => marginTop; set => marginTop = value; }
        public float MarginBottom { get => marginBottom; set => marginBottom = value; }
    
        private void PrintText(object sender, PrintPageEventArgs e)
        {

        }
    }
}
