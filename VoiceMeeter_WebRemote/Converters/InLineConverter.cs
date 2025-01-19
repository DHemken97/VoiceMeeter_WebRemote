namespace VoiceMeeter_WebRemote.Converters
{
    public static class InLineConverter
    {
        public static string ToPx(this object value) => $"{value}px";
        public static string ToPercent(this object value) => $"{value}%";
        public static string Concat(params string[] args) => string.Join("", args) ;
    }
}
