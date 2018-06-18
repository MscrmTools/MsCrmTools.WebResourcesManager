namespace Jsbeautifier
{
    public class BeautifierFlags
    {
        public BeautifierFlags(string mode)
        {
            PreviousMode = "BLOCK";
            Mode = mode;
            VarLine = false;
            VarLineTainted = false;
            VarLineReindented = false;
            InHtmlComment = false;
            IfLine = false;
            ChainExtraIndentation = 0;
            InCase = false;
            InCaseStatement = false;
            CaseBody = false;
            EatNextSpace = false;
            IndentationLevel = 0;
            TernaryDepth = 0;
        }

        public bool CaseBody { get; set; }
        public int ChainExtraIndentation { get; set; }
        public bool EatNextSpace { get; set; }
        public bool IfLine { get; set; }
        public bool InCase { get; set; }
        public bool InCaseStatement { get; set; }
        public int IndentationLevel { get; set; }
        public bool InHtmlComment { get; set; }
        public string Mode { get; set; }
        public string PreviousMode { get; set; }
        public int TernaryDepth { get; set; }
        public bool VarLine { get; set; }

        public bool VarLineReindented { get; set; }
        public bool VarLineTainted { get; set; }
    }
}