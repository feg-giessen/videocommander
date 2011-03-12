namespace D16.VideoCommander
{
    /// <summary>
    /// Build for global (not file specific) vlc arguments.
    /// </summary>
    class VlcCommandBuilder : VlcArgumentBuilder
    {
        /// <summary>
        /// Sets the audio language (e.g. for dvd).
        /// </summary>
        /// <param name="isoCode">The iso code.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetLanguage(string isoCode)
        {
            SetString("--audio-language", isoCode);
            return this;
        }

        /// <summary>
        /// If set to true, video is played in fullscreen.
        /// </summary>
        /// <param name="fullscreen">True for fullscreen.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetFullscreen(bool fullscreen)
        {
            SetBoolean(fullscreen, "--fullscreen", "--no-fullscreen");

            return this;
        }

        /// <summary>
        /// If set to true, video is embedded in the vlc control interface.
        /// </summary>
        /// <param name="embedded">True for embedding video in the control interface.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetEmbedded(bool embedded)
        {
            SetBoolean(embedded, "--embedded-video", "--no-embedded-video");

            return this;
        }

        /// <summary>
        /// Sets the width of the video window.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetWidth(int width)
        {
            SetString("--width", width.ToString());
            return this;
        }

        /// <summary>
        /// Sets the height of the video window.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetHeight(int height)
        {
            SetString("--height", height.ToString());
            return this;
        }

        /// <summary>
        /// Sets the X position of the video window.
        /// </summary>
        /// <param name="xpos">The xpos.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetXPos(int xpos)
        {
            SetString("--video-x", xpos.ToString());
            return this;
        }

        /// <summary>
        /// Sets the Y position of the video window.
        /// </summary>
        /// <param name="ypos">The ypos.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetYPos(int ypos)
        {
            SetString("--video-y", ypos.ToString());
            return this;
        }

        /// <summary>
        /// If set to true, the video title is shown on play.
        /// </summary>
        /// <param name="showTitle">True for showing the title.</param>
        /// <returns></returns>
        public VlcCommandBuilder SetVideoTitleShow(bool showTitle)
        {
            SetBoolean(showTitle, "--video-title-show", "--no-video-title-show");

            return this;
        }
    }
}
