﻿using System;

namespace RazorEngineCore.Tests.Models
{
    public class TestModel1 : RazorEngineTemplateBase
    {
        public int A { get; set; }
        public int B { get; set; }
        public string C { get; set; }
        public DateTime D { get; set; }

        public string Decorator(string text)
        {
            return "-=" + text + "=-";
        }
    }
}