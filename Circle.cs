    public class Circle
    {
        public char _circleChar { get; set; }
        public int _radius { get; set; }
        public string _Color { get; set; }
        public int _posX { get; set; }
        public int _posY { get; set; }

        private bool _ShowCursor = Console.CursorVisible = false;
        public Circle(int posY, int posX, int radius, string color, char circleChar)
        {
            _posY = posY;
            _posX = posX;
            _Color = color;
            _radius = radius;
            _circleChar = circleChar;
        }

        public void Draw()
        {
            for (int y = -_radius; y <= _radius; y++)
            {
                for (int x = -_radius; x <= _radius; x++)
                {
                    double distance = Math.Sqrt(x * x + (y * 2) * (y * 2));
                    if (distance <= _radius)
                    {
                        MayaDrawing.consoleColor(_Color);
                        MayaDrawing.consoleColor("defaultbg");
                        MayaDrawing.CharToPosition(_posY + y, _posX + x / 3 - 1, _circleChar);
                    }
                    else
                    {
                        MayaDrawing.consoleColor("defaultbg");
                        MayaDrawing.CharToPosition(_posY, _posX, ' ');
                    }
                }
            }
            _ShowCursor = false;
        }
    }
