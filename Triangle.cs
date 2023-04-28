    public class Triangle
    {
        public int _Height { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public Triangle(int posY, int posX, int height, string color, char styleFilled)
        {
            _Height = height;
            _posY = posY;
            _posX = posX;
            _Color = color;
            _Style = styleFilled;
        }
        public void Draw()
        {
            MayaDrawing.consoleColor(_Color);
            MayaDrawing.consoleColor("defaultbg");

            for (int i = 1; i <= _Height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    MayaDrawing.CharToPosition(_posY + i + 1, _posX + j, _Style);
                }
            }
            Console.CursorVisible = false;
            return;
        }
    }
