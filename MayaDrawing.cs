public static void WriteFileToPos(int width, int height, string color, string file)
        {
            if (File.Exists(file))
            {
                string text = File.ReadAllText(file);
                Console.CursorVisible = false;
                consoleColor(color);
                WriteStringToPosition(width, height, text);
            }
        }
        public static void WriteStringToPosition(int posX, int posY, string value)
        {
            if (posX > 0 && posX < Console.WindowHeight &&
                posY > 0 && posY < Console.WindowWidth)
            {
                Console.SetCursorPosition(posY, posX);
                Console.Write(value);
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;
            }
        }
        public static string ReturnString(string value)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            return value;
        }
        public static void CharToPosition(int posX, int posY, char Char)
        {
            if (posX <= 0 || posY <= 0) { return; }
            if (posX >= Console.WindowWidth || posY >= Console.WindowHeight) { return; }

            Console.SetCursorPosition(posX, posY);
            Console.Write(Char);
            Console.CursorVisible = false;
        }
        public static void WriteCharToPosition(int posX, int posY, char value)
        {
            WriteStringToPosition(posX, posY, value.ToString());
        }
        public static char ReturnChar(char value)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            return value;
        }
        public static string ReplaceChar(string file, char a, char b)
        {
            string content = File.ReadAllText(file);
            content = content.Replace(a, b);
            File.WriteAllText(file, content);
            return content;
        }
        // Comparing
        public static bool IsCharEqual(char chA, char chB)
        {
            Console.WriteLine(chA.Equals(chB));
            return true;

        }
        public static bool IsNotCharEqual(char chA, char chB)
        {
            Console.WriteLine(chB.Equals(chA));
            return false;

        }
        public static List<int> FindStrings(string[] search, string searchIn)
        {
            List<int> indices = new List<int>();
            foreach (string searchString in search)
            {
                int index = searchIn.IndexOf(searchString);
                if (index != -1)
                {
                    indices.Add(index);
                }
            }
            return indices;
        }
        public static string GetMaxWindowSize()
        {
            return $"{Console.WindowWidth} {Console.WindowHeight}";
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
        public static void FillBG(string colorbg)
        {
            char[,] consoleArray = new char[Console.WindowWidth, Console.WindowHeight];
            int row;
            int col;
            consoleColor(colorbg);
            while (true)
            {
                for (row = 1; row < Console.WindowHeight; row++)
                {
                    for (col = 1; col < Console.WindowWidth; col++)
                    {
                        consoleArray[row, col] = ' ';
                    }
                }
                for (row = 1; row < Console.WindowHeight; row++)
                {
                    for (col = 1; col < Console.WindowWidth; col++)
                    {
                        Console.Write(consoleArray[row, col]);
                    }
                }
            }
        }
        public static void FillFG(string colorbg)
        {
            char[,] consoleArray = new char[Console.WindowWidth, Console.WindowHeight];
            int row;
            int col;
            consoleColor(colorbg);
            while (true)
            {
                for (row = 1; row < Console.WindowHeight; row++)
                {
                    for (col = 1; col < Console.WindowWidth; col++)
                    {
                        consoleArray[row, col] = ' ';
                    }
                }
                for (row = 1; row < Console.WindowHeight; row++)
                {
                    for (col = 1; col < Console.WindowWidth; col++)
                    {
                        Console.Write(consoleArray[row, col]);
                    }
                }
            }
        }
    }
