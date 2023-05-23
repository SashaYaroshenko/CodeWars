using System.Diagnostics;
using System.Linq;
namespace LibraryDuplicateEncoder
{
    public class Kata1
    {
        public static string DuplicateEncode(string word)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string result = "";
            word = word.ToLower();
            char[] chars = word.ToCharArray();

            foreach (char c in chars)
            {
                char ch = c;
                int cnt = chars.Count(x => x == c);
                if (cnt > 1)
                {
                    result += ')';
                }
                else
                {
                    result += '(';
                }
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);
            string elapsedTime = ts.TotalMilliseconds.ToString();
            Debug.WriteLine("RunTime " + elapsedTime);

            return result;
        }
    }
}
