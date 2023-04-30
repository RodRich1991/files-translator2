namespace Files_Translator
{
    public class Configuration
    {
        public string DictionaryPath { get; set; }
        public string ProjectPath { get; set; }
        public uint KeyColumn { get; set; }
        public uint ValueColumn { get; set; }
        public bool SkipHeader { get; set; }
        public string FileSufix { get; set; }
        public string SearchRegex { get; set; }
        public string LogFileName { get; set; }
    }
}
