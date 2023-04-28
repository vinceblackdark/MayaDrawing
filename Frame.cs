    public class Frame
    {
        public int _WindowWidth { get; set; }
        public int _WindowHeight { get; set; }
        public int _BufferWidth { get; set; }
        public int _BufferHeight { get; set; }
        public string _Color { get; set; }
        public char _FrameChar { get; set; }
        public bool _ShowCursor = Console.CursorVisible = false;
        public Frame(int WindowWidth, int WindowHeight, int BufferWidth, int BufferHeight, string FrameBorderColor, char FrameChar)
        {
            _WindowWidth = WindowWidth;
            _WindowHeight = WindowHeight;
            _BufferWidth = BufferWidth;
            _BufferHeight = BufferHeight;
            _Color = FrameBorderColor;
            _FrameChar = FrameChar;
        }
        public void Draw()
        {
            int Width = _WindowWidth;
            int Height = _WindowHeight;
            Width -= 1;
            Height -= 1;
            Console.SetWindowSize(_WindowWidth, _WindowHeight);
            Console.SetBufferSize(_BufferWidth, _BufferHeight);
            MayaDrawing.consoleColor(_Color);
            MayaDrawing.consoleColor("defaultbg");
            
            for (int x = 0; x < Height; x++) { MayaDrawing.CharToPosition(Width, x, _FrameChar); 
            for (int x = 0; x < Height; x++) { MayaDrawing.CharToPosition(1, x, _FrameChar);     
            for (int y = 1; y < Width; y++) { MayaDrawing.CharToPosition(y, 1, _FrameChar); }
            for (int y = 1; y < Width; y++) { MayaDrawing.CharToPosition(y, Height, _FrameChar); }       
            MayaDrawing.CharToPosition(1, 1, _FrameChar);
            MayaDrawing.CharToPosition(Width, 1, _FrameChar);
            MayaDrawing.CharToPosition(1, Height, _FrameChar);
            MayaDrawing.CharToPosition(Width, Height, _FrameChar);
            Console.SetWindowSize(_WindowWidth, _WindowHeight);
            Console.SetBufferSize(_BufferWidth, _BufferHeight);
            _ShowCursor = false;
            return;
        }
    }
