    public class LineVertical
    {
        public int _length { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }
        public LineVertical(int posX, int posY, int length, string color, char style)
        {
            _length = length;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            MayaDrawing.consoleColor(_Color);

            for (int y = 0; y < _length; y++)
            { MayaDrawing.CharToPosition(_posX, _posY + y, _Style); }
            Console.CursorVisible = false;
            return;
        }

    }
     public class LineHorizontal
    {
        public int _length { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }

        public LineHorizontal(int posX, int posY, int length, string color, char style)
        {
            _length = length;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = style;
        }
        public void Draw()
        {
            MayaDrawing.consoleColor(_Color);

            for (int y = 0; y < _length; y++) { MayaDrawing.CharToPosition(_posY + y, _posX, _Style); }
            Console.CursorVisible = false;
            return;
        }


    }
