namespace Maya.Drawing
{
	public class MayaDrawing
    {
        private static int largestMaxWidth = Console.LargestWindowWidth;
      
        private static int largestMaxHeight = Console.LargestWindowHeight;
        public static void WriteFileToPos(int width, int height, string color, string file)
        {
            if (File.Exists(file))
            {
                string text = File.ReadAllText(file);
                Console.CursorVisible = false;
                MayaDrawing.consoleColor(color);
                MayaDrawing.WriteStringToPosition(width, height,file);
            }
            else { return; }
        }
        public static void WriteStringToPosition(int posX, int posY, string value)
        {
            if (posX <= 0 || posY <= 0) { return; }
            if (posY >= Console.WindowWidth || posX >= Console.WindowHeight) { return; }

            Console.SetCursorPosition(posY,posX);
            Console.Write(value);
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            return;
        }
        public static string ReturnString(string value)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            return value; 
        }
        public static void CharToPosition(int posY, int posX, char Char)
        {
            if (posX <= 0 || posY <= 0) { return; }
            if (posY >= Console.WindowWidth || posX >= Console.WindowHeight) { return; }

            Console.SetCursorPosition(posY, posX);
            Console.Write(Char);
            Console.CursorVisible = false;
            return;
        }
        public static char ReturnChar(char value)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            return value;
        }
        public static void ReplaceChar(string file, char a, char b)
        {
            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == a) { Console.Write(b); }

                    else { Console.Write(lines[i][j]); }
                }
                Console.WriteLine();
            }
        }
        public static void FindString(string[] search, string searchin)
        {
            string myString = searchin;

            string[] searchStrings = search;

            // string[] searchStrings = { "ist", "x", "ein" };

            foreach (string searchString in searchStrings)
            {
                int index = myString.IndexOf(searchString);
                if (index == -1)
                {
                    Console.WriteLine($"{searchString} nicht gefunden.");
                }
                else
                {
                    Console.WriteLine($"{searchString} gefunden an Index {index}.");
                }
            }
        }
        public static string GetMaxWindowSize()
        {
            string Max = largestMaxWidth + " " + largestMaxHeight;
            return Max;
        }

        public static ConsoleColor _getColor = new ConsoleColor();
        public static ConsoleColor consoleColor(string _Color)
        {
            switch (_Color.ToString())
            {
                case "redfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Red;
                case "redbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Red;
                case "greenfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Green;
                case "greenbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Green;
                case "bluefg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Blue;
                case "bluebg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Blue;
                case "yellowfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Yellow;
                case "yellowbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Yellow;
                case "magentafg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Magenta;
                case "magentabg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Magenta;
                case "cyanfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Cyan;
                case "cyanbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Cyan;
                case "grayfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.Gray;
                case "graybg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Gray;
                case "whitefg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.White;
                case "whitebg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.White;
                case "darkredfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkRed;
                case "darkredbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkRed;
                case "darkgreenfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkGreen;
                case "darkgreenbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkGreen;
                case "darkbluefg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkBlue;
                case "darkbluebg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkBlue;
                case "darkyellowfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkYellow;
                case "darkyellowbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkYellow;
                case "darkmagentafg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkMagenta;
                case "darkmagentabg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkMagenta;
                case "darkcyanfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkCyan;
                case "darkcyanbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkCyan;
                case "darkgrayfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.DarkGray;
                case "darkgraybg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.DarkGray;
                case "blackfg":
                    return _getColor = Console.ForegroundColor = ConsoleColor.White;
                case "defaultbg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Black;
                case "defaultfg":
                    return _getColor = Console.BackgroundColor = ConsoleColor.Black;
                case "default":
                    return ColorDefault();
                default:
                    return _getColor = Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static ConsoleColor ColorDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            return Console.BackgroundColor & Console.ForegroundColor;
        }
        public static string GetCodePage()
        { string codepage = Console.InputEncoding.CodePage.ToString(); return codepage; }
    }
} 
 