﻿using System;
using System.Text.RegularExpressions;

namespace Kong
{
    /// <summary>
    /// Represents a browser.
    /// </summary>
    public class Browser
    {
        static readonly Regex AndroidOSVersionRegex = new Regex(@"android[ \/-](\d+(\.\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex AndroidRegex = new Regex(@"android", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BadaOSVersionRegex = new Regex(@"bada\/(\d+(\.\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BadaRegex = new Regex(@"bada", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BadaVersionRegex = new Regex(@"dolfin\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BlackberryOSVersionRegex = new Regex(@"rim\stablet\sos\s(\d+(\.\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BlackberryRegex = new Regex(@"blackberry|\bbb\d+", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BlackberryVersionRegex = new Regex(@"blackberry[\d]+\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex BlinkRegex = new Regex(@"(apple)?webkit\/537\.36", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex ChromiumRegex = new Regex(@"chromium", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex ChromiumVersionRegex = new Regex(@"(?:chromium)[\s\/](\d+(?:\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex ChromeOSRegex = new Regex(@"CrOS", RegexOptions.ECMAScript | RegexOptions.Compiled);
        static readonly Regex ChromeOSVersionRegex = new Regex(@"(?:chrome|crios|crmo)\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex ChromeRegex = new Regex(@"chrome|crios|crmo", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex ChromeVersionRegex = new Regex(@"(?:chrome|crios|crmo)\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex CoastRegex = new Regex(@"coast", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex CoastVersionRegex = new Regex(@"(?:coast)[\s\/](\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex EdgeRegex = new Regex(@"chrome.+? edg", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex EdgeVersionRegex = new Regex(@"edge\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex EpiphanyRegex = new Regex(@"epiphany", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex EpiphanyVersionRegex = new Regex(@"(?:epiphany)[\s\/](\d+(?:\.\d+)+)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex FirefoxRegex = new Regex(@"firefox|iceweasel|fxios", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex FirefoxOSRegex = new Regex(@"\((mobile|tablet);[^\)]*rv:[\d\.]+\)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex FirefoxVersionRegex = new Regex(@"(?:firefox|iceweasel|fxios)[ \/](\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex GeckoRegex = new Regex(@"gecko", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex GeckoVersionRegex = new Regex(@"gecko\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex GooglebotRegex = new Regex(@"googlebot", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex GooglebotVersionRegex = new Regex(@"googlebot\/(\d+(\.\d+))", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex IEMobileVersionRegex = new Regex(@"iemobile\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex InternetExplorerRegex = new Regex(@"msie|trident", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex InternetExplorerVersionRegex = new Regex(@"(?:msie |rv:)(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex iOSDeviceRegex = new Regex(@"(ipod|iphone|ipad)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex iOSOSVersionRegex = new Regex(@"os (\d+([_\s]\d+)*) like mac os x", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex iOSOSVersionReplaceRegex = new Regex(@"[_\s]", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex KMeleonRegex = new Regex(@"k-meleon", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex KMeleonVersionRegex = new Regex(@"(?:k-meleon)[\s\/](\d+(?:\.\d+)+)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex LikeAndroidRegex = new Regex(@"like android", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex LinuxRegex = new Regex(@"linux", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex MacRegex = new Regex(@"macintosh", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex macOSOSVersionRegex = new Regex(@"Mac OS X (\d+([_\.\s]\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex macOSOSVersionReplaceRegex = new Regex(@"Mac OS X (\d+([_\.\s]\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex MobileRegex = new Regex(@"[^-]mobi", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex MaxthonRegex = new Regex(@"mxios", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex MaxthonVersionRegex = new Regex(@"(?:mxios)[\s\/](\d+(?:\.\d+)+)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex NexusMobileRegex = new Regex(@"nexus\s*[0-6]\s*", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex NexusTabletRegex = new Regex(@"nexus\s*[0-9]+", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex NewOperaRegex = new Regex(@"opr\/|opios", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex NewOperaVersionRegex = new Regex(@"(?:opr|opios)[\s\/](\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex OldOperaRegex = new Regex(@"opera", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex OldOperaVersionRegex = new Regex(@"(?:opera|opr|opios)[\s\/](\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex PuffinRegex = new Regex(@"puffin", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex PuffinVersionRegex = new Regex(@"(?:puffin)[\s\/](\d+(?:\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex PhantomJsRegex = new Regex(@"phantom", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex PhantomJsVersionRegex = new Regex(@"phantomjs\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex QupZillaRegex = new Regex(@"qupzilla", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex QupZillaVersionRegex = new Regex(@"(?:qupzilla)[\s\/](\d+(?:\.\d+)+)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex RimRegex = new Regex(@"rim\stablet", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SafariRegex = new Regex(@"safari|applewebkit", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SailfishRegex = new Regex(@"sailfish", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SailfishVersionRegex = new Regex(@"sailfish\s?browser\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SamsungBrowserRegex = new Regex(@"SamsungBrowser", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SamsungBrowserVersionRegex = new Regex(@"(?:SamsungBrowser)[\s\/](\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SeaMonkeyRegex = new Regex(@"seamonkey\/", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SeaMonkeyVersionRegex = new Regex(@"seamonkey\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SilkRegex = new Regex(@"silk", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SilkVersionRegex = new Regex(@"silk\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SleipnirRegex = new Regex(@"sleipnir", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SleipnirVersionRegex = new Regex(@"(?:sleipnir)[\s\/](\d+(?:\.\d+)+)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SlimerJsRegex = new Regex(@"slimerjs", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex SlimerJsVersionRegex = new Regex(@"slimerjs\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex TabletRegex = new Regex(@"tablet", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex TabletPCRegex = new Regex(@"tablet pc", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex TizenOSVersionRegex = new Regex(@"tizen[\/\s](\d+(\.\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex TizenRegex = new Regex(@"tizen", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex TizenVersionRegex = new Regex(@"(?:tizen\s?)?browser\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex TouchPadRegex = new Regex(@"touchpad\/", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex UcBrowserRegex = new Regex(@"ucbrowser", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex UcBrowserVersionRegex = new Regex(@"(?:ucbrowser)[\s\/](\d+(?:\.\d+)+)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex UnknownRegex = new Regex(@"^(.*)\/(.*) ", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex VersionIdentifierRegex = new Regex(@"version\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex VivaldiRegex = new Regex(@"vivaldi", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex VivaldiVersionRegex = new Regex(@"vivaldi\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WebkitRegex = new Regex(@"(apple)?webkit", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WebOSOSVersionRegex = new Regex(@"(?:web|hpw)os\/(\d+(\.\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WebOSRegex = new Regex(@"(web|hpw)os", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WebOSVersionRegex = new Regex(@"w(?:eb)?osbrowser\/(\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WindowsOSVersionRegex = new Regex(@"Windows ((NT|XP)( \d\d?.\d)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WindowsPhoneOSVersionRegex = new Regex(@"windows phone (?:os)?\s?(\d+(\.\d+)*)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WindowsPhoneRegex = new Regex(@"windows phone", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex WindowsRegex = new Regex(@"windows", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex XboxRegex = new Regex(@"xbox", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex YandexBrowserRegex = new Regex(@"yabrowser", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static readonly Regex YandexBrowserVersionRegex = new Regex(@"(?:yabrowser)[\s\/](\d+(\.\d+)?)", RegexOptions.ECMAScript | RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Initializes a new instance of the <see cref="Browser"/> class. 
        /// </summary>
        /// <param name="ua">The value of an HTTP request User-Agent header from the browser to be identified.</param>
        public Browser(string ua)
        {
            Func<Regex, string> getFirstMatch = regex =>
            {
                var match = regex.Match(ua);
                if (match != null && match.Groups.Count > 1)
                    return match.Groups[1].Value;
                return string.Empty;
            };
            Func<Regex, string> getSecondMatch = regex =>
            {
                var match = regex.Match(ua);
                if (match != null && match.Groups.Count > 2)
                    return match.Groups[2].Value;
                return string.Empty;
            };

            var iosDevice = getFirstMatch(iOSDeviceRegex);
            var likeAndroid = LikeAndroidRegex.IsMatch(ua);
            var android = !likeAndroid && AndroidRegex.IsMatch(ua);
            var nexusMobile = NexusMobileRegex.IsMatch(ua);
            var nexusTablet = !nexusMobile && NexusTabletRegex.IsMatch(ua);
            var chromeOS = ChromeOSRegex.IsMatch(ua);
            var silk = SilkRegex.IsMatch(ua);
            var sailfish = SailfishRegex.IsMatch(ua);
            var tizen = TizenRegex.IsMatch(ua);
            var webos = WebOSRegex.IsMatch(ua);
            var windowsPhone = WindowsPhoneRegex.IsMatch(ua);
            var samsungBrowser = SamsungBrowserRegex.IsMatch(ua);
            var windows = !windowsPhone && WindowsRegex.IsMatch(ua);
            var mac = !iosDevice.IsTruthy() && !silk && MacRegex.IsMatch(ua);
            var linux = !android && !sailfish && !tizen && !webos && LinuxRegex.IsMatch(ua);
            var edgeVersion = getFirstMatch(EdgeVersionRegex);
            var versionIdentifier = getFirstMatch(VersionIdentifierRegex);
            var tablet = TabletRegex.IsMatch(ua) && !TabletPCRegex.IsMatch(ua);
            var mobile = !tablet && MobileRegex.IsMatch(ua);
            var xbox = XboxRegex.IsMatch(ua);

            if (OldOperaRegex.IsMatch(ua))
            {
                Name = "Opera";
                Opera = true;
                Version = versionIdentifier.NullIfFalsy() ?? getFirstMatch(OldOperaVersionRegex);
            }
            else if (NewOperaRegex.IsMatch(ua))
            {
                Name = "Opera";
                Opera = true;
                Version = getFirstMatch(NewOperaVersionRegex).NullIfFalsy() ?? versionIdentifier;
            }
            else if (SamsungBrowserRegex.IsMatch(ua))
            {
                Name = "Samsung Internet for Android";
                SamsungBrowser = true;
                Version = versionIdentifier.NullIfFalsy() ?? getFirstMatch(SamsungBrowserVersionRegex);
            }
            else if (CoastRegex.IsMatch(ua))
            {
                Name = "Opera Coast";
                Coast = true;
                Version = versionIdentifier.NullIfFalsy() ?? getFirstMatch(CoastVersionRegex);
            }
            else if (YandexBrowserRegex.IsMatch(ua))
            {
                Name = "Yandex Browser";
                YandexBrowser = true;
                Version = versionIdentifier.NullIfFalsy() ?? getFirstMatch(YandexBrowserVersionRegex);
            }
            else if (UcBrowserRegex.IsMatch(ua))
            {
                Name = "UC Browser";
                UcBrowser = true;
                Version = getFirstMatch(UcBrowserVersionRegex);
            }
            else if (MaxthonRegex.IsMatch(ua))
            {
                Name = "Maxthon";
                Maxthon = true;
                Version = getFirstMatch(MaxthonVersionRegex);
            }
            else if (EpiphanyRegex.IsMatch(ua))
            {
                Name = "Epiphany";
                Epiphany = true;
                Version = getFirstMatch(EpiphanyVersionRegex);
            }
            else if (PuffinRegex.IsMatch(ua))
            {
                Name = "Puffin";
                Puffin = true;
                Version = getFirstMatch(PuffinVersionRegex);
            }
            else if (SleipnirRegex.IsMatch(ua))
            {
                Name = "Sleipnir";
                Sleipnir = true;
                Version = getFirstMatch(SleipnirVersionRegex);
            }
            else if (KMeleonRegex.IsMatch(ua))
            {
                Name = "K-Meleon";
                KMeleon = true;
                Version = getFirstMatch(KMeleonVersionRegex);
            }
            else if (windowsPhone)
            {
                Name = "Windows Phone";
                WindowsPhone = true;
                if (edgeVersion.IsTruthy())
                {
                    MsEdge = true;
                    Version = edgeVersion;
                }
                else
                {
                    MsIE = true;
                    Version = getFirstMatch(IEMobileVersionRegex);
                }
            }
            else if (InternetExplorerRegex.IsMatch(ua))
            {
                Name = "Internet Explorer";
                MsIE = true;
                Version = getFirstMatch(InternetExplorerVersionRegex);
            }
            else if (chromeOS)
            {
                Name = "Chrome";
                ChromeOS = true;
                ChromeBook = true;
                Chrome = true;
                Version = getFirstMatch(ChromeOSVersionRegex);
            }
            else if (EdgeRegex.IsMatch(ua))
            {
                Name = "Microsoft Edge";
                MsEdge = true;
                Version = edgeVersion;
            }
            else if (VivaldiRegex.IsMatch(ua))
            {
                Name = "Vivaldi";
                Vivaldi = true;
                Version = getFirstMatch(VivaldiVersionRegex).NullIfFalsy() ?? versionIdentifier;
            }
            else if (sailfish)
            {
                Name = "Sailfish";
                Sailfish = true;
                Version = getFirstMatch(SailfishVersionRegex);
            }
            else if (SeaMonkeyRegex.IsMatch(ua))
            {
                Name = "SeaMonkey";
                SeaMonkey = true;
                Version = getFirstMatch(SeaMonkeyVersionRegex);
            }
            else if (FirefoxRegex.IsMatch(ua))
            {
                Name = "Firefox";
                Firefox = true;
                Version = getFirstMatch(FirefoxVersionRegex);
                if (FirefoxOSRegex.IsMatch(ua))
                    FirefoxOS = true;
            }
            else if (silk)
            {
                Name = "Amazon Silk";
                Silk = true;
                Version = getFirstMatch(SilkVersionRegex);
            }
            else if (PhantomJsRegex.IsMatch(ua))
            {
                Name = "PhantomJS";
                Phantom = true;
                Version = getFirstMatch(PhantomJsVersionRegex);
            }
            else if (SlimerJsRegex.IsMatch(ua))
            {
                Name = "SlimerJS";
                Slimer = true;
                Version = getFirstMatch(SlimerJsVersionRegex);
            }
            else if (BlackberryRegex.IsMatch(ua) || RimRegex.IsMatch(ua))
            {
                Name = "Blackberry";
                Blackberry = true;
                Version = versionIdentifier.NullIfFalsy() ?? getFirstMatch(BlackberryVersionRegex);
            }
            else if (webos)
            {
                Name = "WebOS";
                WebOS = true;
                Version = versionIdentifier.NullIfFalsy() ?? getFirstMatch(WebOSVersionRegex);
                if (TouchPadRegex.IsMatch(ua))
                    TouchPad = true;
            }
            else if (BadaRegex.IsMatch(ua))
            {
                Name = "Bada";
                Bada = true;
                Version = getFirstMatch(BadaVersionRegex);
            }
            else if (tizen)
            {
                Name = "Tizen";
                Tizen = true;
                Version = getFirstMatch(TizenVersionRegex).NullIfFalsy() ?? versionIdentifier;
            }
            else if (QupZillaRegex.IsMatch(ua))
            {
                Name = "QupZilla";
                QupZilla = true;
                Version = getFirstMatch(QupZillaVersionRegex).NullIfFalsy() ?? versionIdentifier;
            }
            else if (ChromiumRegex.IsMatch(ua))
            {
                Name = "Chromium";
                Chromium = true;
                Version = getFirstMatch(ChromiumVersionRegex).NullIfFalsy() ?? versionIdentifier;
            }
            else if (ChromeRegex.IsMatch(ua))
            {
                Name = "Chrome";
                Chrome = true;
                Version = getFirstMatch(ChromeVersionRegex);
            }
            else if (android)
            {
                Name = "Android";
                Version = versionIdentifier;
            }
            else if (SafariRegex.IsMatch(ua))
            {
                Name = "Safari";
                Safari = true;
                if (versionIdentifier.IsTruthy())
                    Version = versionIdentifier;
            }
            else if (iosDevice.IsTruthy())
            {
                Name = iosDevice.Equals("iphone", StringComparison.OrdinalIgnoreCase) ? "iPhone" : iosDevice.Equals("ipad", StringComparison.OrdinalIgnoreCase) ? "iPad" : "iPod";
                if (versionIdentifier.IsTruthy())
                    Version = versionIdentifier;
            }
            else if (GooglebotRegex.IsMatch(ua))
            {
                Name = "Googlebot";
                Googlebot = true;
                Version = getFirstMatch(GooglebotVersionRegex).NullIfFalsy() ?? versionIdentifier;
            }
            else
            {
                Name = getFirstMatch(UnknownRegex);
                Version = getSecondMatch(UnknownRegex);
            }

            if (!MsEdge && WebkitRegex.IsMatch(ua))
            {
                if (BlinkRegex.IsMatch(ua))
                {
                    Name = Name.NullIfFalsy() ?? "Blink";
                    Blink = true;
                }
                else
                {
                    Name = Name.NullIfFalsy() ?? "Webkit";
                    Webkit = true;
                }
                if (!Version.IsTruthy() && versionIdentifier.IsTruthy())
                    Version = versionIdentifier;
            }
            else if (!Opera && GeckoRegex.IsMatch(ua))
            {
                Name = Name.NullIfFalsy() ?? "Gecko";
                Gecko = true;
                Version = Version.NullIfFalsy() ?? getFirstMatch(GeckoVersionRegex);
            }

            if (!WindowsPhone && !MsEdge && (android || Silk))
                Android = true;
            else if (!WindowsPhone && !MsEdge && iosDevice.IsTruthy())
            {
                if (iosDevice.Equals("iphone", StringComparison.OrdinalIgnoreCase))
                    iPhone = true;
                else if (iosDevice.Equals("ipad", StringComparison.OrdinalIgnoreCase))
                    iPad = true;
                else
                    iPod = true;
                iOS = true;
            }
            else if (mac)
                Mac = true;
            else if (xbox)
                Xbox = true;
            else if (windows)
                Windows = true;
            else if (linux)
                Linux = true;

            var osVersion = string.Empty;
            if (Windows)
            {
                osVersion = getFirstMatch(WindowsOSVersionRegex);
                if (osVersion == "NT")
                    osVersion = "NT";
                else if (osVersion == "XP")
                    osVersion = "XP";
                else if (osVersion == "NT 5.0")
                    osVersion = "2000";
                else if (osVersion == "NT 5.1")
                    osVersion = "XP";
                else if (osVersion == "NT 5.2")
                    osVersion = "2003";
                else if (osVersion == "NT 6.0")
                    osVersion = "Vista";
                else if (osVersion == "NT 6.1")
                    osVersion = "7";
                else if (osVersion == "NT 6.2")
                    osVersion = "8";
                else if (osVersion == "NT 6.3")
                    osVersion = "8.1";
                else if (osVersion == "NT 10.0")
                    osVersion = "10";
                else
                    osVersion = null;
            }
            else if (WindowsPhone)
                osVersion = getFirstMatch(WindowsPhoneOSVersionRegex);
            else if (Mac)
                osVersion = macOSOSVersionReplaceRegex.Replace(getFirstMatch(macOSOSVersionRegex), ".");
            else if (iosDevice.IsTruthy())
            {
                osVersion = getFirstMatch(iOSOSVersionRegex);
                osVersion = iOSOSVersionReplaceRegex.Replace(osVersion, ".");
            }
            else if (android)
                osVersion = getFirstMatch(AndroidOSVersionRegex);
            else if (WebOS)
                osVersion = getFirstMatch(WebOSOSVersionRegex);
            else if (Blackberry)
                osVersion = getFirstMatch(BlackberryOSVersionRegex);
            else if (Bada)
                osVersion = getFirstMatch(BadaOSVersionRegex);
            else if (Tizen)
                osVersion = getFirstMatch(TizenOSVersionRegex);
            if (osVersion.IsTruthy())
                OSVersion = osVersion;

            var osMajorVersion = Windows ? null : osVersion.Split('.')[0].CoerceToInteger();
            if (tablet ||
                nexusTablet ||
                iosDevice.Equals("ipad", StringComparison.OrdinalIgnoreCase) ||
                (android && (osMajorVersion == 3 || (osMajorVersion >= 4 && !mobile))) ||
                Silk)
                Tablet = true;
            else if (mobile ||
                iosDevice.Equals("iphone", StringComparison.OrdinalIgnoreCase) ||
                iosDevice.Equals("ipod", StringComparison.OrdinalIgnoreCase) ||
                android ||
                nexusMobile ||
                Blackberry ||
                WebOS ||
                Bada)
                Mobile = true;

            var versionFloat = Version.CoerceToFloat();
            if (MsEdge ||
                (MsIE && versionFloat >= 10) ||
                (YandexBrowser && versionFloat >= 15) ||
                (Vivaldi && versionFloat >= 1.0) ||
                (Chrome && versionFloat >= 20) ||
                (SamsungBrowser && versionFloat >= 4) ||
                (Firefox && versionFloat >= 20) ||
                (Safari && versionFloat >= 6) ||
                (Opera && versionFloat >= 10.0) ||
                (iOS && OSVersion.IsTruthy() && int.Parse(OSVersion.Split('.')[0]) >= 6) ||
                (Blackberry && versionFloat >= 10.1) ||
                (Chromium && versionFloat >= 20))
                A = true;
            else if ((MsIE && versionFloat < 10) ||
                (Chrome && versionFloat < 20) ||
                (Firefox && versionFloat < 20.0) ||
                (Safari && versionFloat < 6) ||
                (Opera && versionFloat < 10.0) ||
                (iOS && OSVersion.IsTruthy() && int.Parse(OSVersion.Split('.')[0]) < 6) ||
                (Chromium && versionFloat < 20))
                C = true;
            else
                X = true;
        }

        /// <summary>
        /// Gets whether this browser has full capabilities.
        /// </summary>
        public bool A { get; }
        /// <summary>
        /// Gets whether this is an Android native browser.
        /// </summary>
        public bool Android { get; }
        public bool Bada { get; }
        /// <summary>
        /// Gets whether this is a Blackberry native browser.
        /// </summary>
        public bool Blackberry { get; }
        /// <summary>
        /// Gets whether this browser is based on the Blink web browser engine, e.g. Chrome version 28 or later.
        /// </summary>
        public bool Blink { get; }
        /// <summary>
        /// Gets whether this browser has degraded capabilities (serve simpler versions).
        /// </summary>
        public bool C { get; }
        /// <summary>
        /// Gets whether this browser is Chrome.
        /// </summary>
        public bool Chrome { get; }
        public bool ChromeBook { get; }
        public bool ChromeOS { get; }
        public bool Chromium { get; }
        public bool Coast { get; }
        public bool Epiphany { get; }
        /// <summary>
        /// Gets whether this browser is Firefox.
        /// </summary>
        public bool Firefox { get; }
        /// <summary>
        /// Gets whether this browser is running on Firefox OS.
        /// </summary>
        public bool FirefoxOS { get; }
        /// <summary>
        /// Gets whether this browser is based on the Gecko web browser engine, e.g. Firefox.
        /// </summary>
        public bool Gecko { get; }
        public bool Googlebot { get; }
        /// <summary>
        /// Gets whether this is an iOS native browser.
        /// </summary>
        public bool iOS { get; }
        /// <summary>
        /// Gets whether this browser is running on an iPad.
        /// </summary>
        public bool iPad { get; }
        /// <summary>
        /// Gets whether this browser is running on an iPhone.
        /// </summary>
        public bool iPhone { get; }
        /// <summary>
        /// Gets whether this browser is running on an iPod.
        /// </summary>
        public bool iPod { get; }
        /// <summary>
        /// Gets whether this browser is running on Linux (other than Android, ChromeOS, WebOS, Tizen, and Sailfish).
        /// </summary>
        public bool Linux { get; }
        public bool KMeleon { get; }
        /// <summary>
        /// Gets whether this browser is running on a Mac.
        /// </summary>
        public bool Mac { get; }
        public bool Maxthon { get; }
        /// <summary>
        /// Gets whether this browser is running on a mobile device.
        /// </summary>
        public bool Mobile { get; }
        /// <summary>
        /// Gets whether this browser is Microsoft Edge.
        /// </summary>
        public bool MsEdge { get; }
        /// <summary>
        /// Gets whether this browser is Microsoft Internet Explorer.
        /// </summary>
        public bool MsIE { get; }
        /// <summary>
        /// Gets a human readable name for this browser, e.g. "Chrome".
        /// </summary>
        public string Name { get; }
        public bool Opera { get; }
        /// <summary>
        /// Gets the version of the operating system on which this browser is running.
        /// </summary>
        public string OSVersion { get; }
        public bool Phantom { get; }
        public bool Puffin { get; }
        public bool QupZilla { get; }
        /// <summary>
        /// Gets whether this browser is Safari.
        /// </summary>
        public bool Safari { get; }
        public bool Sailfish { get; }
        public bool SamsungBrowser { get; }
        public bool SeaMonkey { get; }
        /// <summary>
        /// Gets whether this is a the Amazon Kindle browser.
        /// </summary>
        public bool Silk { get; }
        public bool Sleipnir { get; }
        public bool Slimer { get; }
        /// <summary>
        /// Gets whether this browser is running on a tablet device.
        /// </summary>
        public bool Tablet { get; }
        public bool Tizen { get; }
        /// <summary>
        /// Gets whether this browser is running on an HP TouchPad.
        /// </summary>
        public bool TouchPad { get; }
        /// <summary>
        /// Gets a version number for the browser, e.g. "32.0".
        /// </summary>
        public string Version { get; }
        public bool YandexBrowser { get; }
        public bool UcBrowser { get; }
        public bool Vivaldi { get; }
        /// <summary>
        /// Gets whether this browser is based on the Webkit web browser engine, e.g. Safari, Chrome version 27 or earlier.
        /// </summary>
        public bool Webkit { get; }
        /// <summary>
        /// Gets whether this is a WebOS native browser.
        /// </summary>
        public bool WebOS { get; }
        /// <summary>
        /// Gets whether this browser is running on Windows.
        /// </summary>
        public bool Windows { get; }
        /// <summary>
        /// Gets whether this browser is running on Windows Phone.
        /// </summary>
        public bool WindowsPhone { get; }
        /// <summary>
        /// Gets whether this browser has minimal capabilities and is probably not well-detected.
        /// </summary>
        public bool X { get; }
        public bool Xbox { get; }
    }
}
