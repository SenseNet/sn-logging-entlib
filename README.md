# sensenet Enterprise Library Event Logger
Event Logger plugin for [sensenet](https://github.com/SenseNet/sensenet) that uses the Logging module of **Microsoft Enterprise Library**.

[![NuGet](https://img.shields.io/nuget/v/SenseNet.EntlibLogger.svg)](https://www.nuget.org/packages/SenseNet.EntlibLogger)

Use this package if you want to send event log entries through _Enterprise Library_. A basic event logger that sends events the Windows Event Log is available in the [SenseNet.Tools](https://www.nuget.org/packages/SenseNet.Tools) library, you do not need this package if you need only that.

This package gives operators more flexibility on formatting and directing event message to different targets.

> This package is available only for applications that are built on the .Net Framework. .Net Core applications should use a more modern a logging provider.