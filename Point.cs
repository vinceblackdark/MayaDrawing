    public class Point
    {
        private int _Width { get; set; }
        private int _Height { get; set; }
        public int _moveY { get; set; }
        public int _moveX { get; set; }
        public int _lastPosY { get; set; }
        public int _lastPosX { get; set; }
        public int _steps { get; set; }
        public int _posY { get; set; }
        public int _posX { get; set; }
        public string _Color { get; set; }
        public char _Style { get; set; }
        public bool _isLastPosition { get; set; }

        public bool _ShowCursor = Console.CursorVisible = false;
        public Point(int posY, int posX, string color, char style)
        {
            _Height = 1;
            _Width = 1;
            _Color = color;
            _Style = style;
            _moveX = 0;
            _moveY = 0;
            _steps = 1;
            _posY = posY;
            _posX = posX;
        }
        public void Draw(Point point)
        {
            MayaDrawing.consoleColor(point._Color);
            MayaDrawing.CharToPosition(point._posY, point._posX, point._Style);
            Console.CursorVisible = false;
            return;
        }
        public void Move(Point point, string direction, int steps)
        {
            switch (direction.ToString())
            {
                case "left":
                    if (point._posY <= 3) { return; }
                    else
                    {
                        point._posY -= steps;
                        break;
                    }
                case "right":
                    if (point._posY >= Console.WindowWidth - 4) { return; }
                    else
                    {
                        point._posY += steps;
                        break;
                    }
                case "down":
                    if (point._posX >= Console.WindowHeight - 4) { return; }
                    else
                    {
                        point._posX += steps;
                        break;
                    }

                case "up":
                    if (point._posX <= 2) { return; }
                    else
                    {
                        point._posX -= steps;
                        break;
                    }
                default: break;
            }
            Draw(point);
            DeleteLast(direction, point._posY, point._posX);
            Console.CursorVisible = false;
            return;
        }
        void DeleteLast(string direction, int posY, int posX)
        {
            switch (direction.ToString())
            {
                case "left":
                    MayaDrawing.CharToPosition(posY + 1, posX, Sprites._charEmpty);
                    break;
                case "right":
                    MayaDrawing.CharToPosition(posY - 1, posX, Sprites._charEmpty);
                    break;
                case "down":
                    MayaDrawing.CharToPosition(posY, posX - 1, Sprites._charEmpty);
                    break;
                case "up":
                    MayaDrawing.CharToPosition(posY, posX + 1, Sprites._charEmpty);
                    break;
                default:
                    break;
            }
            Console.CursorVisible = false;
            return;
        }

    }
