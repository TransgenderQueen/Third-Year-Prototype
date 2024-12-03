
# Soulslike Impact

<br>

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

---

<br>
<br>

# Week 2

### Controller Support
 - Controller support became an issue. Playstation Crontrollers were unuseable after Unreal Engine 5. Controllers require a plugin that has not been updated, and therefore is very unreliable. So after long enough of attempting to fix the issues, I had to give up with playstation four or five controllers.
 - However, I also had plans to use Xbox controllers, which are supported by Windows, and therefore are easy to set up with controller. After this, all I needed to do was to make a bunch of extra input actions for every single button, which didnt take long at all.

---

### Player UI
 - Created the UI
 - Made a simple health bar, with plan to add the stamina bar in the future. I then also added the visal of an Estus Flask as a tempory object for the prototype, which i will have to amend in the future. Since then I also added in a small image above the health flask to show what weapon the player had equipped.
 ---

 ### Research
 ---
 - For this week I resarched the Minecraft modpack 'Vault Hunters'. It is a modpack based around looting dungeons for new weapons, resources and upgrades for your Minecraft world. One of the key features is the randomized gear, which you can gain gear from little crates, or random enemy or chest drops from the vaults. 
 - The randomized gear can have different status effects, from higher damage, to quicker attack speed. The full list is;
    * Attack Damage
    * Attack Speed
    * Durability
    * Chaining
    * Soul Chance
    * Effect Clouds
    * Effect Chance

- These can be found or crafted, with percentage chances on the modifiers on the weapons. The amount of modifiers and the percentage of the modfiers are effected by the rarity of the weapon itself. I looked at thse weapons and thought it could be a unique and interesting way to fight enemies, making it a unique game. 
- An example of this could be: I have an element called Frost, when you hit an enemy with a weapon imbued by frost, they will slow by a certain amount.
- When hit, they will have a build up of frost, for this example i will say it is a build of of 33% a hit. 
  * Hit 1 - 33% build up, 33% slowed
  * Hit 2 - 66% build up, 66% slowed
  * Hit 3 - 99% build up, 99% slowed
  * Hit 4 - 100% build up, 100% slowed
- When it hits 100% build up, It will trigger a further status effect. In this example it is shatter, which will deal a percentage of damage to the enemy, chnging based on resistances.
---

<br>
<br>

# Week ;3

:3

random weapon system



# Week 4

basic enemy
enemy attacking system


# Week 5

Lock on system


# Week 6 
 
 weapon affliction system

# Week 7

doging
testing

# Week 8

testing

dungeon making.

# week 9
testing




<br>
<br>
<br>

 # Bibliography
---
 https://vaulthunters.gg/ 


 https://www.sololearn.com/en/ 
 :3