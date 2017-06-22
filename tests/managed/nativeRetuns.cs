using System;

#if __MACOS__
using PlatformColor = AppKit.NSColor;
#elif __IOS__
using PlatformColor = UIKit.UIColor;
#endif


#if __MACOS__ || __IOS__
namespace NativeReturns
{
	public class Colors
	{
		public Colors ()
		{
		}

		public PlatformColor Color { get; }

		public PlatformColor CalculateFavoriteColor ()
		{
			return null;
		}
	}
}
#endif