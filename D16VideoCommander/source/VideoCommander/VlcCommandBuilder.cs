namespace D16.VideoCommander
{
    class VlcCommandBuilder : VlcArgumentBuilder
    {
        public VlcCommandBuilder SetLanguage(string isoCode)
        {
            SetString("--audio-language", isoCode);
            return this;
        }

        public VlcCommandBuilder SetFullscreen(bool fullscreen)
        {
            SetBoolean(fullscreen, "--fullscreen", "--no-fullscreen");

            return this;
        }

        public VlcCommandBuilder SetEmbedded(bool embedded)
        {
            SetBoolean(embedded, "--embedded-video", "--no-embedded-video");

            return this;
        }

        public VlcCommandBuilder SetWidth(int width)
        {
            SetString("--width", width.ToString());
            return this;
        }

        public VlcCommandBuilder SetHeight(int height)
        {
            SetString("--height", height.ToString());
            return this;
        }

        public VlcCommandBuilder SetXPos(int xpos)
        {
            SetString("--video-x", xpos.ToString());
            return this;
        }

        public VlcCommandBuilder SetYPos(int ypos)
        {
            SetString("--video-y", ypos.ToString());
            return this;
        }

        public VlcCommandBuilder SetVideoTitleShow(bool showTitle)
        {
            SetBoolean(showTitle, "--video-title-show", "--no-video-title-show");

            return this;
        }
    }
}
