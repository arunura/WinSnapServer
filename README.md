# Window Snapshot Server

[![.NET Core Desktop](https://github.com/arunura/WinSnapServer/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/arunura/WinSnapServer/actions/workflows/dotnet-desktop.yml)

The WSS app can publish one of the windows on your Windows desktop to a remote host over HTTP by taking periodic scheenshots of the window. 

## Features
1. Capture window screens from all virtual desktops
2. Capture screens of minimized windows
3. Publishes screenshot over HTTP port 7777.
4. Auto wakeup client device through reverse HTTP connection (when using [wifikeyboard](https://github.com/ivanvolosyuk/wifikeyboard)). 


## Requirements
1. .Net Framework 4.8
2. Visual Studio 2019


## Potential Uses
1. Give new life to an old tablet and use it as an additional "monitor".
2. Photoframe on your wall or calendar on your refrigerator. Limited only by what you can run on your windows desktop.


## Acknowlegements
1. Based on the work by [Hessam Jalali](https://www.codeproject.com/Articles/20651/Capturing-Minimized-Window-A-Kid-s-Trick) to cature window screensnaps.
2. Makes use of [Ivan Volosyuk's wifikeyboard](https://github.com/ivanvolosyuk/wifikeyboard) to keep client device awake.
