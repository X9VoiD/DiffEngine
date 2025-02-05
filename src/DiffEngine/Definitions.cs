﻿static class Definitions
{
    public static IReadOnlyList<Definition> Tools { get; }

    static Definitions() =>
        Tools = new List<Definition>
        {
            Implementation.BeyondCompare(),
            Implementation.P4MergeText(),
            Implementation.Kaleidoscope(),
            Implementation.DeltaWalker(),
            Implementation.WinMerge(),
            Implementation.DiffMerge(),
            Implementation.TortoiseMerge(),
            Implementation.TortoiseGitMerge(),
            Implementation.TortoiseIDiff(),
            Implementation.KDiff3(),
            Implementation.TkDiff(),
            Implementation.Guiffy(),
            Implementation.ExamDiff(),
            Implementation.Diffinity(),
            Implementation.P4MergeImage(),
            Implementation.Rider(),
            Implementation.Vim(),
            Implementation.Neovim(),
            Implementation.AraxisMerge(),
            Implementation.Meld(),
            Implementation.SublimeMerge(),
            Implementation.CodeCompare(),
            Implementation.VisualStudioCode(),
            Implementation.VisualStudio()
        };
}