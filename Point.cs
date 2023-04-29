public class Point
    {
        private int _moveY;
        private int _moveX;
        private int _lastPosY;
        private int _lastPosX;
        public int _posY { get; set; }
        public int _posX { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }
        private bool _isLastPosition;
        public bool _ShowCursor = Console.CursorVisible = false;
        public Point(int posY, int posX, string color, char style)
        {
            _Color = color;
            _Style = style;
            _moveX = 0;
            _moveY = 0;
            _posY = posY;
            _posX = posX;
        }
        public void Draw()
        {
            MayaDrawing.consoleColor(_Color);
            MayaDrawing.CharToPosition(_posY,_posX, _Style);
            Console.CursorVisible = false;
        }
        public void Move(string direction)
        {
            int steps = 1;
            _isLastPosition = true;

            _posX = _lastPosX;
            _posY = _lastPosY;

            switch (direction.ToString())
            {
                case "left":
                    if (_posY <= 3) { return; }
                    else
                    {
                        _posY -= steps;
                        _moveY -= steps;
                        break;
                    }
                case "right":
                    if (_posY >= Console.WindowWidth - 4) { return; }
                    else
                    {
                        _posY += steps;
                        _moveY += steps;
                        break;
                    }
                case "down":
                    if (_posX >= Console.WindowHeight - 4) { return; }
                    else
                    {
                        _posX += steps;
                        _moveX += steps;
                        break;
                    }

                case "up":
                    if (_posX <= 2) { return; }
                    else
                    {
                        _posX -= steps;
                        _moveX -= steps;
                        break;
                    }
                default: break;
            }
            Draw();
            MayaDrawing.CharToPosition(_lastPosX, _lastPosY, Sprites._charEmpty);
            Console.CursorVisible = false;  
        }
    }
