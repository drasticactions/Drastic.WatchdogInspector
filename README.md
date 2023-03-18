[![NuGet Version](https://img.shields.io/nuget/v/Drastic.WatchdogInspector.svg)](https://www.nuget.org/packages/Drastic.WatchdogInspector/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.WatchdogInspector

Drastic.WatchdogInspector is a binding of [WatchdogInspector](https://github.com/tapwork/WatchdogInspector) for .NET iOS and tvOS. This helps detect slowdowns and perf issues when running too much code on the UI Thread.

![screencast](https://user-images.githubusercontent.com/898335/226085235-68077079-8a11-480f-b24b-045188522df0.gif)

## How To Use

- Include the Drastic.WatchdogInspector nuget
- Run `Drastic.WatchdogInspector.TWWatchdogInspector.Start();`
- This will start the session in your status bar and your console.

