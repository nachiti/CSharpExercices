using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            String [] phrase = sentence.Split(' ');
            Array.Reverse(phrase);
            return String.Join(" ", phrase);
        }
    }
}
