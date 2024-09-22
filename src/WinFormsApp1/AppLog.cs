namespace WinFormsApp1
{
    public enum CommType
    {
        Rx,
        Tx
    }

    public class LogBase
    {
        public DateTime Time;
        public string Message = string.Empty;
    }

    public class ActLog : LogBase
    {
    }

    public class CommLog : LogBase
    {
        public CommType CommType;

        public string SrcAddr = string.Empty;
        public int SrcPort = 0;

        public string DstAddr = string.Empty;
        public int DstPort = 0;

        public string Data = string.Empty;
    }
}
