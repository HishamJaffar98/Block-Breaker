# Block-Breaker
A synthwave themed 2D Arkanoid game built in Unity using C# and Audacity (*for audio editing*).

# Project Structure
This repository consists of four folders:-

1. [Assets](Assets)
2. [Final_Game_Builds](Final_Game_Builds)
3. [Packages](Packages)
4. [Project Settings](ProjectSettings)

Out which the [Assets](Assets) and [Final_Game_Builds](Final_Game_Builds) are the only files to be concerned with if a user wants to understand the inner workings of the game or play the final build, respectively.

## Assets
This consists of the all the entities used to make the game. These entities (assets) can be categorized as:-
1. [Audio](Assets/Audio)
2. [Fonts](Assets/Fonts)
3. [Materials](Assets/Materials)
4. [Prefabs](Assets/PreFabs)
5. [Scenes](Assets/Scenes)
6. [Scripts](Assets/Scripts)
7. [Sprites](Assets/Sprites)

## Builds
The [Final_Game_Builds](Final_Game_Builds) folder consists of two final builds of the game. These builds are:-

1. A standalone PC build ---->[PC](Final_Game_Builds/Block_Breaker_PC_Build)
2. A WebGL build         ---->[WebGL](Final_Game_Builds/Block_Breaker_Web)

# Running the Game
To run the game using the PC build :-

- Download the Repository.
- Open the [Final_Game_Builds](Final_Game_Builds) folder.
- Open the [Block_Breaker_PC_Build](Final_Game_Builds/Block_Breaker_PC_Build) folder.
- Double click the `Block Breaker.exe` executable to run the game.

To run the game using the WebGL build :-

- Download the Repository.
- Open the [Final_Game_Builds](Final_Game_Builds) folder.
- Open the [Block_Breaker_Web](Final_Game_Builds/Block_Breaker_Web) folder.
- Right Click the `index.html` and chose `open with` **Microsoft Edge** or **Mozilla Firefox** (*Only these two browsers can run WEBGL builds without further configurations*)

# Instructions and Controls
Move the paddle to **destroy all the blocks** within a level without letting the ball fall down. You will have **three balls** per level to do so.

Controls:-
- Use `Left Mouse Click` to select UI options (*Start Menu, Game Over Screen and Pause Menu*)
- Use `Mouse` to move the paddle within the game
- Use `Left Mouse Click` within a level to launch the ball
- Use `Escape` to toggle the pause menu

# Further Information
For detailed design specifications please refer to the [Wiki](https://github.com/HishamJaffar98/Block-Breaker/wiki/Block-Breaker-Design) of this repository.
