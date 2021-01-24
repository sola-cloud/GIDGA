using System;

namespace GIDGA
{
    public class _ga
    {
        public string version { get; set; }
        public string root { get; set; }
        public string GenGa
        {
            get { return $"GA{version}.{root}.{uid()}.{timestamp()}"; }   
        }
        private static string timestamp()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
        }
        private static string uid()
        {
            var unqId = string.Empty;

            while (unqId.Length < 10)
                unqId += new Random().Next(1, 9).ToString();
            return unqId;
        }
    }
}
