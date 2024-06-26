﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;


namespace SORA_Class
{
    class Report
    {
        private Font fontType;
        private StreamReader printFile;
        private float marginLeft;
        private float marginRight;
        private float marginTop;
        private float marginBottom;

        public Report(Font fontType, string path, float marginLeft, float marginRight, float marginTop, float marginBottom)
        {
            FontType = fontType;
            PrintFile = new StreamReader(path);
            MarginLeft = marginLeft;
            MarginRight = marginRight;
            MarginTop = marginTop;
            MarginBottom = marginBottom;
        }

        public Font FontType { get => fontType; set => fontType = value; }
        public StreamReader PrintFile { get => printFile; set => printFile = value; }
        public float MarginLeft { get => marginLeft; set => marginLeft = value; }
        public float MarginRight { get => marginRight; set => marginRight = value; }
        public float MarginTop { get => marginTop; set => marginTop = value; }
        public float MarginBottom { get => marginBottom; set => marginBottom = value; }
    
        private void PrintText(object sender, PrintPageEventArgs e)
        {
            int maxRow = (int)((e.MarginBounds.Height - MarginTop - MarginBottom) / FontType.GetHeight(e.Graphics));
            float y = MarginTop;
            int rowNum = 0;

            string rowText = PrintFile.ReadLine();

            while(rowNum < maxRow && rowText != null)
            {
                y = MarginTop + (rowNum * FontType.GetHeight(e.Graphics));

                e.Graphics.DrawString(rowText, FontType, Brushes.Black, MarginLeft, y);
                rowNum++;
                rowText = PrintFile.ReadLine();
            }
            if(rowText != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void SendToPrinter()
        {
            PrintDocument document = new PrintDocument();
            document.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            document.PrintPage += new PrintPageEventHandler(PrintText);
            document.Print();

            PrintFile.Close();
        }
    }
}
