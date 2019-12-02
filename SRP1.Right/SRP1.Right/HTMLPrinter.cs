﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SRP1.Right
{
    class HTMLPrinter : IPrinter
    {
        public void PrintPage(string pageContent)
        {
            Console.WriteLine($"<div id = \"page\">{pageContent}</div>");
        }
    }
}
