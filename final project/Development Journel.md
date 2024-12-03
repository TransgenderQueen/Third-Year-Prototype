
# Soulslike Impact

<br>

<iframe src = "https://trello.com/b/0r9vNMYR" frameBorder="0" width="50%" height="300"> </iframe>


# Week One

## Colour Blindness

- Different colour blindness's can perceive colours differently.
- Symbols are a main way to show differences. Caduceus for health, or a heart symbol
- Consider haptic feedback with controller, consider a heart beat
- Make the edge of the screen darker to show the
 - Audio for healing potions and taking damage, or a heartbeat
---
 <br>
 <br>


## Controller Support

 - Playstation 5 controller has a diffeent scheme to the playstation 4 controller.
  - Uses completly seperate axis settings, needing a lot of trial and error to find the correct settings.
  - Playstation 4 controller uses 'Generic Gamepad Axis' 1 through 3, whereas Playstation 5 controller Uses 'Generic Gamepad Axis' 4 through 7
  - Mapping buttons to specific actions was increadibly easy, just requiring a new input for specific buttons. However, I also had to create multiple new keybinds, such as;
    * Dodge/Run,
    * Light Attack,
    * Heavy Attack,
    * Drink Potion,
    * Collect/Switch Item,
    * Lock on,
---

<br>
<br>

## Movement System

 - The Movement system is rather simplistic, being based on other souls-like games
 - There are three new movement buttons:
   * Sprint
   * Backstep (Tap sprint button while not moving)
   * Dodge (Tap sprint button while moving.)

 - Soulslike games put emphasis on timing and being careful with movements. So This is what I am using for my movement system. I want it to be very similar, so there will be fewer movement options.
 - However, Like other souls-like games, I will be including a lock on system, which makes it a little easier for people in games such as this, where enemies have such large and co-ordinated movements.
---
 <br>
 <br>

## Weapons
### Weapon Types
---
There will be a few different types of weapons, each with their own set of animations. These types are:
  * Swords, which have very short range
  * Spears, which have a long range, but only stab
  * Scyhes, which have a long range, slashing at the enemie(s)
  * Greatsowrds, which have a medium range, slashing the enemie(s)
Alongside this, there will be a diferent type of stats for each weapon.
----
### Weapon Stats
---
 Each weapon will have three main Stat - Damage, Attack Speed and Stamina Drain. All of which are rather easy to understand what they will do. I will also have different stats for different weapon types, some can be shared, others cannot.
  - Shared stats;
     * Bleed
     * Slowness
 - Sword Stats;
   * Poison
- Spear Stats;
   * Peircing
- Scythe Stats;
    * Fire,
    * Lifesteal,
 - Greatsword Stats;





## Research

## Respawn System

For the respawn system I wanted to use one that had the iconic 'You Died' System from all the soulslike games. this will include a slow death animation from the character, before the dark bar appears on screen, with the 'You Died' text.

![![DarkSouls You Died Screen](image.png)](image.png)
*Figure 1. Shows an example of a death screen from the game Dark Souls One.*

I wanted to stick as close to the orginal source as possible. This was done by creating a new User Interface that would pop up when a player died. This would then call up the small animtion I had created for the UI, the black bar and red text showing up for a moment before vanishing. This UI is then instantly killed as it is no longer necessary.


