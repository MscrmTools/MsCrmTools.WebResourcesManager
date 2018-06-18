namespace Jsbeautifier
{
    public class BeautifierOptions
    {
        public BeautifierOptions()
        {
            IndentSize = 4;
            IndentChar = ' ';
            IndentWithTabs = false;
            PreserveNewlines = true;
            MaxPreserveNewlines = 10.0f;
            JslintHappy = false;
            BraceStyle = BraceStyle.Collapse;
            KeepArrayIndentation = false;
            KeepFunctionIndentation = false;
            EvalCode = false;
            //this.UnescapeStrings = false;
            BreakChainedMethods = false;
        }

        public BraceStyle BraceStyle { get; set; }
        public bool BreakChainedMethods { get; set; }
        public bool EvalCode { get; set; }
        public char IndentChar { get; set; }
        public uint IndentSize { get; set; }
        public bool IndentWithTabs { get; set; }

        public bool JslintHappy { get; set; }
        public bool KeepArrayIndentation { get; set; }
        public bool KeepFunctionIndentation { get; set; }
        public float MaxPreserveNewlines { get; set; }
        public bool PreserveNewlines { get; set; }

        //public bool UnescapeStrings { get; set; }
        public static BeautifierOptions DefaultOptions()
        {
            return new BeautifierOptions();
        }
    }
}