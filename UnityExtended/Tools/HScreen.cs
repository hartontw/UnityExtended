using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// An extended version of UnityEngine.Screen
    /// </summary>
    public static class HScreen
    {
        /// <summary>
        /// Returns Top coordinate of the Screen.
        /// </summary>
        public static Vector2 Top { get { return new Vector2(Screen.width * 0.5f, Screen.height); } }

        /// <summary>
        /// Returns Bottom coordinate of the Screen.
        /// </summary>
        public static Vector2 Bottom { get { return new Vector2(Screen.width * 0.5f, 0); } }

        /// <summary>
        /// Returns Right coordinate of the Screen.
        /// </summary>
        public static Vector2 Right { get { return new Vector2(Screen.width, Screen.height * 0.5f); } }

        /// <summary>
        /// Returns Left coordinate of the Screen.
        /// </summary>
        public static Vector2 Left { get { return new Vector2(0, Screen.height * 0.5f); } }

        /// <summary>
        /// Returns Center coordinate of the Screen.
        /// </summary>
        public static Vector2 Center { get { return new Vector2(Screen.width * 0.5f, Screen.height * 0.5f); } }

        /// <summary>
        /// Returns BottomLeft coordinate of the Screen.
        /// </summary>
        public static Vector2 BottomLeft { get { return new Vector2(0, 0); } }

        /// <summary>
        /// Returns TopLeft coordinate of the Screen.
        /// </summary>
        public static Vector2 TopLeft { get { return new Vector2(0, Screen.height); } }

        /// <summary>
        /// Returns TopRight coordinate of the Screen.
        /// </summary>
        public static Vector2 TopRight { get { return new Vector2(Screen.width, Screen.height); } }

        /// <summary>
        /// Returns BottomRight coordinate of the Screen.
        /// </summary>
        public static Vector2 BottomRight { get { return new Vector2(Screen.width, 0); } }

        /// <summary>
        /// Returns the screen bounds using this center as origin.
        /// </summary>
        public static Bounds Bounds { get { return new Bounds(Center, new Vector2(Width, Height)); } }

        /// <summary>
        /// A power saving setting, allowing the screen to dim some time after the last active user interaction.
        /// </summary>
        public static int SleepTimeout
        {
            get { return Screen.sleepTimeout; }
            set { Screen.sleepTimeout = value; }
        }

        /// <summary>
        /// Specifies logical orientation of the screen.
        /// </summary>
        public static ScreenOrientation Orientation
        {
            get { return Screen.orientation; }
            set { Screen.orientation = value; }
        }

        /// <summary>
        /// Allow auto-rotation to landscape right?
        /// </summary>
        public static bool AutorotateToLandscapeRight
        {
            get { return Screen.autorotateToLandscapeRight; }
            set { Screen.autorotateToLandscapeRight = value; }
        }

        /// <summary>
        /// Allow auto-rotation to landscape left?
        /// </summary>
        public static bool AutorotateToLandscapeLeft
        {
            get { return Screen.autorotateToLandscapeLeft; }
            set { Screen.autorotateToLandscapeLeft = value; }
        }

        /// <summary>
        /// Allow auto-rotation to portrait, upside down?
        /// </summary>
        public static bool AutorotateToPortraitUpsideDown
        {
            get { return Screen.autorotateToPortraitUpsideDown; }
            set { Screen.autorotateToPortraitUpsideDown = value; }
        }

        /// <summary>
        /// Allow auto-rotation to portrait?
        /// </summary>
        public static bool AutorotateToPortrait
        {
            get { return Screen.autorotateToPortrait; }
            set { Screen.autorotateToPortrait = value; }
        }

        /// <summary>
        /// Is the game running fullscreen?
        /// </summary>
        public static bool FullScreen
        {
            get { return Screen.fullScreen; }
            set { Screen.fullScreen = value; }
        }

        /// <summary>
        /// The current DPI of the screen / device (Read Only).
        /// </summary>
        public static float DPI { get { return Screen.dpi; } }

        /// <summary>
        /// The current height of the screen window in pixels (Read Only).
        /// </summary>
        public static int Height { get { return Screen.height; } }

        /// <summary>
        /// The current width of the screen window in pixels (Read Only).
        /// </summary>
        public static int Width { get { return Screen.width; } }

        /// <summary>
        /// The current screen resolution (Read Only).
        /// </summary>
        public static Resolution CurrentResolution { get { return Screen.currentResolution; } }

        /// <summary>
        /// All fullscreen resolutions supported by the monitor (Read Only).
        /// </summary>
        public static Resolution[] Resolutions { get { return Screen.resolutions; } }

        /// <summary>
        /// Switches the screen resolution.
        /// </summary>
        public static void SetResolution(int width, int height, bool fullscreen)
        {
            Screen.SetResolution(width, height, fullscreen);
        }

        /// <summary>
        /// Switches the screen resolution.
        /// </summary>
        public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
        {
            Screen.SetResolution(width, height, fullscreen, preferredRefreshRate);
        }
    }
}