#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2026 ShareX Team
    Modifications copyright (c) 2026 Gameknight963

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System;

namespace ShareX.HelpersLib
{
    public static class Links
    {
        public const string Website = "https://gameknight963.com";

        [Obsolete("Won't work")]
        public const string Callback = Website + "/callback/";
        [Obsolete("Won't work")]
        public const string Changelog = Website + "/changelog";
        [Obsolete("Won't work")]
        public const string Donate = Website + "/donate";
        [Obsolete("Won't work")]
        public const string PrivacyPolicy = Website + "/privacy-policy";
        [Obsolete("Won't work")]
        public const string ImageEffects = Website + "/image-effects";
        [Obsolete("Won't work")]
        public const string Actions = Website + "/actions";
        [Obsolete("Won't work")]
        private const string Docs = Website + "/docs";
        [Obsolete("Won't work")]
        public const string DocsCustomUploader = Docs + "/custom-uploader";
        [Obsolete("Won't work")]
        public const string DocsKeybinds = Docs + "/keybinds";
        [Obsolete("Won't work")]
        public const string DocsOCR = Docs + "/ocr";
        [Obsolete("Won't work")]
        public const string DocsScrollingScreenshot = Docs + "/scrolling-screenshot";

        public const string GitHub = "https://github.com/Gameknight963/ShareX-NoVibecodedUi";
        public const string GitHubIssues = GitHub + "/issues?q=is%3Aissue";

        [Obsolete("Should be removed")]
        public const string Jaex = "https://github.com/Jaex";
        [Obsolete("Should be removed")]
        public const string McoreD = "https://github.com/McoreD";
        [Obsolete("Should be removed")]
        public const string Discord = "https://discord.gg/ShareX";
        [Obsolete("Should be removed")]
        public const string X = "https://x.com/ShareX";
        [Obsolete("Should be removed")]
        public const string XFollow = "https://x.com/intent/follow?screen_name=ShareX";
        [Obsolete("Should be removed")]
        public const string Reddit = "https://www.reddit.com/r/sharex";
        [Obsolete("Should be removed")]
        public const string Steam = "https://store.steampowered.com/app/400040/ShareX/";
        [Obsolete("Should be removed")]
        public const string MicrosoftStore = "https://apps.microsoft.com/detail/9nblggh4z1sp";
    }
}