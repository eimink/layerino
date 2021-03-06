# layerino
Tournament layout system for use with OBS Studio

Built initially for using with The Kaupunkisota Overwatch tournament, but has been used for other tournaments as well. :)

layerino consists of html pages and a control application for Windows.

![layerino](https://cdn.pbrd.co/images/GVhLxJy.png)

## Features
* Top of the screen layer for displaying team names and map scores with easy team switching from side to side

* Fullscreen layer for displaying teams and their logos for upcoming match

* Simple eight team bracket

* Easily switchable top logos and overlay graphics for in-game overlay

## Instructions
1) Build layerino or download binaries from [releases](https://github.com/eimink/layerino/releases/)

2) Run layerino.exe

3) For in-game top of the screen layer, add a BrowserSource with size of 1920x1080 to OBS and point it to local file html/ingame_OW.html from this repo.

4) For fullscreen layer with team names and logos, add a BrowserSource with size of 1920x1080 to OBS and point it to local file html/fullscreen_match.html from this repo.

5) Set team names in layerino & hit refresh

## Hotkeys

Global hotkeys have been configured to the software as follows:

CTRL + ALT + 4 = Increment Team 1 Score

CTRL + ALT + 5 = Decrement Team 1 Score

CTRL + ALT + 6 = Increment Team 2 Score

CTRL + ALT + 7 = Decrement Team 2 Score

CTRL + ALT + 8 = Swap Teams

CTRL + ALT + 9 = Refresh All

CTRL + ALT + 0 = Toggle Visibility

## Upcoming features

* More options for brackets

## Show some support

If you wish to support development of Layerino, feel free to buy me a beer or lunch when we meet at Assembly/LanTrek/??? or on the streets or throw your monies at me via [paypal.me/eimink](https://paypal.me/eimink)
