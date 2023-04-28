    public class Rectangle
    {
        public int _Width { get; set; }
        public int _Height { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }

        public bool _ShowCursor = Console.CursorVisible = false;
        public Rectangle(int posY, int posX, int width, int height, string color, char style)
        {
            _Width = width;
            _Height = height;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            MayaDrawing.consoleColor(_Color);
            MayaDrawing.consoleColor("defaultbg");
            for (int x = 0; x < _Height; x++) { MayaDrawing.CharToPosition(_posY, _posX + x, _Style); } // Left Border
            for (int x = 0; x < _Height; x++) { MayaDrawing.CharToPosition(_posY + _Width - 1, _posX + x, _Style); } // Right Border
            for (int y = 0; y < _Width; y++) { MayaDrawing.CharToPosition(_posY + y, _posX, _Style); } // Top Border
            for (int y = 0; y < _Width; y++) { MayaDrawing.CharToPosition(_posY + y, _posX + _Height - 1, _Style); } // Bottom
            _ShowCursor = false;
            return;
        }
    }
    public class RectangleFilled
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor Color { get; set; }
        public char _Style { get; set; }

        private int _WindowWidth = Console.WindowWidth;
        private int _WndowHeight = Console.WindowHeight;

        public bool _ShowCursor = Console.CursorVisible = false;
        public RectangleFilled(int posY, int posX, int width, int height, ConsoleColor color, char style)
        {
            X = posX;
            Y = posY;
            Width = width;
            Height = height;
            Color = color;
            _Style = style;
        }
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Color;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(_Style);
                }
                Console.SetCursorPosition(X, Y + i + 1);
            }
            Console.ResetColor();
            _ShowCursor = false;
            return;
        }
    }
