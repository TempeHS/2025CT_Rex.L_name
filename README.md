# <p align=center> :grapes:  Berry Bounce  :strawberry:

<!-- Table of Contents -->
- [Description](#description)
- [Objective](#objective)
- [Development Process](#development-process)
- [Software Used](#software-used)
- [Controls](#controls)
- [Game Elements](#game-elements)
  - [Timer Display](#timer-display-ui)
  - [Level Display](#level-display-ui)
  - [Collectables](#collectables)
  - [Moving Platforms](#moving-platforms)
  - [Themed Environments](#themed-environments)
  - [Smooth Level Transitions](#smooth-level-transitions)
  - [Main Menu and Death Screen](#main-menu)
- [Player](#player)
  - [Animations](#animations)
- [Scripts](#all-scripts)


---

## Game Walkthrough

https://github.com/user-attachments/assets/d93eaf9d-fbdf-497a-bdd0-a693743b8305


## Description
Berry Bounce is a 2D platformer made in Unity that tests the player's ability to reach the end level whilst having enough time to complete all objectives. There is no traditional healthbar, rather the player's time will slowly decrease and once it reaches zero, the player loses. The game will increase in difficulty as you progress through levels with some levels introducing new mechanics such as moving platforms. Throughout the entire game the player's vision will be limited with only the immediate surroundings being visible. Credits to Jazlyn for the assets provided. 


### Objective
Reach the end of all the levels whilst keeping your current time in mind. Some levels may require collecting keys scattered around the map to progress to the next level. There are also collectables around each map shaped as clocks which can add to your current time so try to look for them as your time runs low. Once you are sure you have collected all keys within a level, you should find the exit which looks something like a door/tunnel. 


### Development Process
The development process was full of bugs and errors with many issues arising in regards to player animations, colliders and hitboxes, sprite sizes and scripting bugs. Whilst most issues were in some form fixed in the end, there are still a few issues in the game outlined below.

- **Screen Tearing (Fixable with sprite atlas)**
- **Platform Collider Shapes**
- **Player Animations (Sprites being different sizes and blurry)**
- **Level Display not updating properly sometimes**

There have also been some features that were not implemented in time but were imagined to be within the game, also outlined below.

- **Level Selection Menu**
- **Enemy AI**
- **More Abilities, Powerups and Collectables**
- **Better Movement Physics**
- **More Levels**
- **Sound Effects and Music**

### Software Used
#### Visual Studio Code
![alt text](image-3.png)

#### Unity Game Engine
![alt text](image-4.png)

---

## Controls

#### :computer: Keyboard     

| Key Bind | Action |
| ----------- | ----------- |
| <kbd>A</kbd> | Move Left |
| <kbd>D</kbd> | Move Right |
| <kbd>Q</kbd> | Dash |
| <kbd>Spacebar</kbd> | Jump |

#### :video_game: Controller

| Key Bind | Action |
| ----------- | ----------- |
| Left Joystick | Move Left & Right |
| Y | Jump |
| B | Dash |
---

## Game Elements

### Timer Display UI

#### Static
![A screenshot showing the timer UI element in Berry Bounce](image.png)
#### Counting Down
![alt text](timerCountdown.gif)

### Level Display UI
![alt text](levelRefresh.gif)

### Collectables
| Key Collectable | Clock Collectable |
| ----------- | ----------- |
| ![alt text](keyAnimation.gif)| ![alt text](clockCollectable-1.gif) |

### Moving Platforms
![alt text](movingPlatform.gif)

### Themed Environments
#### Forest
![alt text](image-1.png)
#### Snowy Forest
![alt text](image-2.png)

### Smooth Level Transitions
![alt text](levelTransition.gif)

### Main Menu 
![alt text](<Screenshot 2025-11-05 122844.png>)

## Player
### Animations
| Player Idle | Player Run |
| ----------- | ----------- |
| ![alt text](playerIdleAnimation.gif) | ![alt text](playerRunAnimation.gif) |

#### Player Jump
![alt text](playerJumpAnimation.gif)
#### Player Death
![alt text](playerDeathAnimation.gif)

## [All Scripts](https://github.com/TempeHS/2025CT_Rex.L_name/tree/main/Assets/Scripts)