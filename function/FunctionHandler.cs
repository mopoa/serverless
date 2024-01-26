using System;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Function
{
    public class FunctionHandler
    {
        public string Handle(string input) {
            string output="";
            string[] lines = input.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                
                if (lines[i].Length > 10)
                {
                    lines[i] = lines[i][0] + (lines[i].Length - 2).ToString() + lines[i][lines[i].Length - 1];
                }
            }
            for (int i = 0; i < lines.Length; i++)
            {
                output+=lines[i]+"\n";
            }
            return output;
        }
    }
}
