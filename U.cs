using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCalc_VeryBad
{
    public class U
    {
        private static readonly List<string> histrory = new List<string>();
        public static ReadOnlyCollection<string> History => histrory.AsReadOnly();

        internal static void AddToHistory(string entry)
        {
            histrory.Add(entry);
        }

        private static string _last = "";
        public static string Last
        {
            get => _last;
            set => _last = value ?? string.Empty;
        }

        private static int _counter = 0;
        public static int Counter
        {
            get => _counter;
            internal set => _counter = value;
        }

        private string _misc;
        public string misc
        {
            get => _misc;
            set => _misc = value;
        }
    }
}
