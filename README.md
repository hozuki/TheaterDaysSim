# Theater Days Simulator

A simulator for [THE iDOLM@STER Million Live! Theater Days](https://millionlive.idolmaster.jp/theaterdays/), based on [MilliSim](https://github.com/hozuki/MilliSim) framework.

| Downloads | Status |
|--|--|
| [GitHub Releases](https://github.com/hozuki/TheaterDaysSim/releases) | ![GitHub (pre-)release](https://img.shields.io/github/release/hozuki/TheaterDaysSim/all.svg) ![Github All Releases](https://img.shields.io/github/downloads/hozuki/TheaterDaysSim/total.svg) |
| [AppVeyor](https://ci.appveyor.com/api/projects/hozuki/TheaterDaysSim/artifacts/tdsim-appveyor-latest.zip) | (latest development build) |

| Build Status | |
|--|--|
| AppVeyor | [![AppVeyor](https://img.shields.io/appveyor/ci/hozuki/TheaterDaysSim.svg)](https://ci.appveyor.com/project/hozuki/TheaterDaysSim) |

**Stage:** alpha

**Miscellaneous:**

[![GitHub contributors](https://img.shields.io/github/contributors/hozuki/TheaterDaysSim.svg)](https://github.com/hozuki/TheaterDaysSim/graphs/contributors)
[![Libraries.io for GitHub](https://img.shields.io/librariesio/github/hozuki/TheaterDaysSim.svg)](https://github.com/hozuki/TheaterDaysSim)
[![license](https://img.shields.io/github/license/hozuki/TheaterDaysSim.svg)](LICENSE.txt)

## Usage

**Requirements:**

- Operating System:
  - Windows: Windows 7 SP1 or later
    - [.NET Framework 4.5](https://www.microsoft.com/en-us/download/details.aspx?id=42642)
  - macOS and Linux: macOS 10.8 / Ubuntu 16.04 or later
    - and latest [Wine](https://wiki.winehq.org/Download) (will download `wine-mono` on launch)
- [Visual C++ 2015 Runtime](https://www.microsoft.com/en-us/download/details.aspx?id=53587)
- OpenAL (bundled OpenAL-Soft Win32 build in newer releases)

OpenGL builds (`TheaterDays.OpenGL.exe`) can run on all platforms, but it is problematic.
DirectX builds (`TheaterDays.Direct3D11.exe`) can only run on Windows.

### Note: Video Playback Support

See [here](https://github.com/hozuki/MilliSim#note-video-playback-support).

## License

MIT
