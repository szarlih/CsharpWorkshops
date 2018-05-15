namespace TextSearch
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Text.RegularExpressions;

    static class Search
    {
        private const int margin = 20;

        public static BindingList<string> Find(string fraza, string body)
        {
            BindingList<string> result = new BindingList<string>();
            Regex pattern = new Regex(fraza.ToLower());
            MatchCollection matchList = pattern.Matches(body.ToLower());
            int start = 0;
            int end = margin * 2;
            foreach (Match hit in matchList)
            {
                if (hit.Index <= margin)
                {
                    start = 0;
                }
                else
                {
                    start = hit.Index - margin;
                }

                end = hit.Index + hit.Length + margin;
                if (end < body.Length)
                {
                    end = hit.Length + margin * 2;
                }
                else
                {
                    end = body.Length - hit.Index - 1;
                }

                result.Add(body.Substring(start, end));

                #if DEBUG
                Console.WriteLine(result.Last());
                #endif
            }

            return result;
        }
    }
}