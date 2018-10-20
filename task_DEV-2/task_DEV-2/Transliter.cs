using System;
using System.Text;
using System.Text.RegularExpressions;

namespace task_DEV_2
{
    public class Transliter
    {
        private string CyrToLat(char symbol)
        {
            switch (symbol)
            {
                case 'а': return "a";
                case 'б': return "b";
                case 'в': return "v";
                case 'г': return "g";
                case 'д': return "d";
                case 'е': return "e";
                case 'ё': return "yo";
                case 'ж': return "zh";
                case 'з': return "z";
                case 'и': return "i";
                case 'й': return "y";
                case 'к': return "k";
                case 'л': return "l";
                case 'м': return "m";
                case 'н': return "n";
                case 'о': return "o";
                case 'п': return "p";
                case 'р': return "r";
                case 'с': return "s";
                case 'т': return "t";
                case 'у': return "u";
                case 'ф': return "f";
                case 'х': return "kh";
                case 'ц': return "ts";
                case 'ч': return "ch";
                case 'ш': return "sh";
                case 'щ': return "sch";
                case 'ъ': return "'";
                case 'ы': return "i";
                case 'ь': return string.Empty;
                case 'э': return "e";
                case 'ю': return "yu";
                case 'я': return "ya";
                default: return symbol.ToString();
            }
        }

        private string CyrToLat(string row)
        {
            StringBuilder translitRowBuilder = new StringBuilder();
            foreach (char symbol in row.ToLower().ToCharArray())
            {
                translitRowBuilder.Append(CyrToLat(symbol));
            }

            return translitRowBuilder.ToString();
        }

        private string LatToCyr(string row)
        {
            StringBuilder translitRowBuilder = new StringBuilder();
            var symbols = row.ToLower().ToCharArray();

            int i = 0;
            while (i < symbols.Length)
            {
                switch (symbols[i])
                {
                    case 'a': translitRowBuilder.Append('а'); break;
                    case 'b': translitRowBuilder.Append('б'); break;
                    case 'v': translitRowBuilder.Append('в'); break;
                    case 'g': translitRowBuilder.Append('г'); break;
                    case 'd': translitRowBuilder.Append('д'); break;
                    case 'e': translitRowBuilder.Append('е'); break;
                    case 'z':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitRowBuilder.Append('ж'); break; }
                            else { translitRowBuilder.Append('з'); i--; break; }
                        }
                        else { translitRowBuilder.Append('з'); break; }
                    case 'i': translitRowBuilder.Append('и'); break;
                    case 'k':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitRowBuilder.Append('х'); break; }
                            else { translitRowBuilder.Append('к'); i--; break; }
                        }
                        else { translitRowBuilder.Append('к'); break; }
                    case 'l': translitRowBuilder.Append('л'); break;
                    case 'm': translitRowBuilder.Append('м'); break;
                    case 'n': translitRowBuilder.Append('н'); break;
                    case 'o': translitRowBuilder.Append('о'); break;
                    case 'p': translitRowBuilder.Append('п'); break;
                    case 'r': translitRowBuilder.Append('р'); break;
                    case 't':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 's') { translitRowBuilder.Append('ц'); break; }
                            else { translitRowBuilder.Append('т'); i--; break; }
                        }
                        else { translitRowBuilder.Append('т'); break; }
                    case 'u': translitRowBuilder.Append('у'); break;
                    case 'f': translitRowBuilder.Append('ф'); break;
                    case 'y':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'o') { translitRowBuilder.Append('ё'); break; }
                            else if (symbols[i] == 'a') { translitRowBuilder.Append('я'); break; }
                            else if (symbols[i] == 'u') { translitRowBuilder.Append('ю'); break; }
                            else { translitRowBuilder.Append('й'); i--; break; }
                        }
                        else { translitRowBuilder.Append('й'); break; }
                    case 'c':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitRowBuilder.Append('ч'); break; }
                            else { throw new Exception("We cann't translit this sequerence of symbols!"); }
                        }
                        else { throw new Exception("We cann't translit this sequerence of symbols!"); }
                    case 's':
                        if (i + 2 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'c')
                            {
                                i++;
                                if (symbols[i] == 'h') { translitRowBuilder.Append('щ'); break; }
                                else throw new Exception("We cann't translit this sequerence of symbols!");
                            }
                            else if (symbols[i] == 'h') { translitRowBuilder.Append('ш'); break; }
                            else { translitRowBuilder.Append('c'); i--; break; }
                        }
                        else if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitRowBuilder.Append('ш'); break; }
                            else { translitRowBuilder.Append('ш'); i--; break; }
                        }
                        else { translitRowBuilder.Append('с'); break; }
                    case 'h': throw new Exception("We cann't translit this sequerence of symbols!");
                    case 'j': throw new Exception("We cann't translit this sequerence of symbols!");
                    default: translitRowBuilder.Append(symbols[i]); break;
                }
                i++;
            }
            
            return translitRowBuilder.ToString();
        }

        private bool IdentifyLanguage(string row)
        {
            return Regex.IsMatch(row, "[а-яА-ЯеЁ]");
        }

        public string Translit(string row)
        {
            if (IdentifyLanguage(row)) return CyrToLat(row);
            else return LatToCyr(row);
        }

    }
}