# BoucleColorBall
Android Game

Use taps on your phone to control player's ball. Go up across colors of your ball to win.
Game is hard, so you might need some attempts to win :)

In this game i use only 5 scripts:
1) Player
2) Menu
3) Star
4) Rotator
5) Follow player

1. PLayer

2. Menu
This script needs to make scene maenegment in game. There's only one public var:
- RestartPannel. Here should be panel, which activates, when you lose

3. Star 
Script form enemy "Star", which helps enemy to patrol area. Here public vars:
- speed. Float type speed of enemy motion.
- lPos, rPos. Left position and right position of X axis of patrol area

4. Rotator
Script for circle rotation.
- speed. Speed of rotation

5. Follow player
This script helps main camera folow to players ball on Y axis. Only one public var:
- player. Object, whitch Y axis coordinates camera should follow
