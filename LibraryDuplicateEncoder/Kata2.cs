using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LibraryDuplicateEncoder
{
    public class Kata2
    {
        public static string DuplicateEncode(string word)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            word = word.ToUpper();
            string str = "";
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word.IndexOf(word[i].ToString()) ==
                    word.LastIndexOf(word[i].ToString()))
                {
                    str += "(";
                }
                else 
                {
                    str += ")";
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
            return str;
        }
    }
}
