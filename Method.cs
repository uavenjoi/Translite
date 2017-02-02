using System;
using System.Collections.Generic;
using System.Text;

namespace Translite
{
    class Method
    {
        readonly Dictionary<char, string> _dictionary = new Dictionary<char, string>()
        {
            {'а', "a"},
            {'б', "b"},
            {'в', "v"},
            {'г', "h"},
            {'д', "d"},
            {'е', "e"},
            {'ё', "yo"},
            {'ж', "zh"},
            {'з', "z"},
            {'и', "i"},
            {'й', "y"},
            {'к', "k"},
            {'л', "l"},
            {'м', "m"},
            {'н', "n"},
            {'о', "o"},
            {'п', "p"},
            {'р', "r"},
            {'с', "s"},
            {'т', "t"},
            {'у', "u"},
            {'ф', "f"},
            {'х', "kh"},
            {'ц', "ts"},
            {'ч', "ch"},
            {'ш', "sh"},
            {'щ', "shch"},
            {'ь', "`,i"},
            {'ы', "y"},
            {'ъ', "`"},
            {'э', "e"},
            {'ю', "yu"},
            {'я', "ya"}
        };


        public string TransliteString(string text)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var tx in text)
            {
                if (char.IsLetter(tx))
                {
                    //---
                    var letter = _dictionary[Char.ToLower(tx)];
                    builder.Append(letter);
                }
                else
                {
                    builder.Append(tx);
                }
            }

            return builder.ToString();
        }
    }
}
