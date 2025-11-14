# Amazon Nova Desktop

A simple WPF application that displays the Amazon Nova Chat website (https://nova.amazon.com/chat).

## Requirements

- .NET 8.0 SDK or later
- Windows OS
- WebView2 Runtime (usually pre-installed on Windows 11, or can be downloaded from Microsoft)

## Building

1. Open a terminal in this directory
2. Run: `dotnet restore`
3. Run: `dotnet build`
4. Run: `dotnet run`

## Features

- Displays the Amazon Nova Chat website in a full-screen window
- Uses WebView2 for modern web rendering
- Borderless window design (can be resized)

## Notes

- The application window starts maximized with no window borders
- If WebView2 Runtime is not installed, you'll need to download it from: https://developer.microsoft.com/microsoft-edge/webview2/

