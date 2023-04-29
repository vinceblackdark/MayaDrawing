    public class Rectangle
    {
        public int _Width { get; set; }
        public int _Height { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }
        private bool _ShowCursor = Console.CursorVisible = false;
        public Rectangle(int posX, int posY, int width, int height, string color, char style)
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
            for (int x = 0; x < _Height; x++) { MayaDrawing.CharToPosition(_posY, _posX + x, _Style); } 
            for (int x = 0; x < _Height; x++) { MayaDrawing.CharToPosition(_posY + _Width - 1, _posX + x, _Style); } 
            for (int y = 0; y < _Width; y++) { MayaDrawing.CharToPosition(_posY + y, _posX, _Style); } 
            for (int y = 0; y < _Width; y++) { MayaDrawing.CharToPosition(_posY + y, _posX + _Height - 1, _Style); }
            _ShowCursor = true;
        }
    }
