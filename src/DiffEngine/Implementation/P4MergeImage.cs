﻿static partial class Implementation
{
    public static Definition P4MergeImage()
    {
        static string TargetLeftArguments(string temp, string target)
        {
            return $"\"{target}\" \"{temp}\"";
        }

        static string TargetRightArguments(string temp, string target)
        {
            return $"\"{temp}\" \"{target}\"";
        }

        return new(
            name: DiffTool.P4MergeImage,
            url: "https://www.perforce.com/products/helix-core-apps/merge-diff-tool-p4merge",
            autoRefresh: false,
            isMdi: false,
            supportsText: false,
            requiresTarget: true,
            cost: "Free",
            binaryExtensions: new[]
            {
                "bmp",
                "gif",
                "jpg",
                "jpeg",
                "png",
                "pbm",
                "pgm",
                "ppm",
                "tif",
                "tiff",
                "xbm",
                "xpm"
            },
            windows: new(
                TargetLeftArguments,
                TargetRightArguments,
                @"%ProgramFiles%\Perforce\p4merge.exe"),
            linux: new(
                TargetLeftArguments,
                TargetRightArguments,
                "/usr/bin/p4merge"),
            osx: new(
                TargetLeftArguments,
                TargetRightArguments,
                "/Applications/p4merge.app/Contents/MacOS/p4merge"));
    }
}