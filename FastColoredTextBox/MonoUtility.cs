using System;

namespace FastColoredTextBoxCJK
{
    internal class MonoUtility
    {
        private const PlatformID MonoUnix = (PlatformID)128;

        public static bool IsLinux
        {
            get
            {
                PlatformID platform = Environment.OSVersion.Platform;
                if (platform == PlatformID.Unix || platform == PlatformID.MacOSX)
                {
                    return true;
                }
                return (int)platform == 128;
            }
        }

        public MonoUtility()
        {
        }
    }
}