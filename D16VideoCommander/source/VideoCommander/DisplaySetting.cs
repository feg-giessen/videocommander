using System;

namespace D16.VideoCommander
{
    /// <summary>
    /// A display setting.
    /// </summary>
    [Serializable]
    public class DisplaySetting
    {
        public bool Fullscreen { get; set; }
        public bool Embedded { get; set; }
        public bool CloseAfterPlay { get; set; }

        public int XPos { get; set; }
        public int YPos { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
    }
}
