﻿namespace Core.Configurations
{
    public class BrowserConfiguration : IConfiguration
    {
        public string SectionName => "Browser";
        public bool Headless { get; set; }
        public string TypeBrowser { get; set; }
    }
}
