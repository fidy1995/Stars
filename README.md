# Stars
This is a simple Android app made with Unity and Cardboard SDK, showing stars which is brighter than magnitude 3 or 4
(high or low res), at their real positions.

## Problems
This is a naive try, so it is clear that there's still lot of problems-it can't exit elegantly, and it takes too much 
computing and memory resources. I will try fixing them if I have enouth time.

## Purposes
This application is not just for fun.

This application aims at bringing newers for the Amateur Astronomers Association at Jincai Middle School, Shanghai, China, 
hoping to arouse other students'-especially for new Senior Ones-interest in astronomy and astrophysics. These customs at 
Jincai are well-known, but it's losing its advantages. By making this application, I will try my best to aid the association.

## Update log

### Version 1.2
- Deleted annoying trees, now you are at the seaside.

- Move the Polaris to declination 31°, in order to provide the view of Shanghai, but I'm not considering adding Jinmao Building XDDDDD

- Now every time you open the APP, the sky sphere will spin a random angle to provide different views.

- Make lighting easier to render by using directional lights, not point lights. And also, removing lens flares.

### Version 1.1
- Fixed a bug that cause the constellations to become image symmetrical.

- Make the stars more realistic by reducing the strength of the lights' lens flares.

- Now the low res pack will show all stars that is brighter than magnitude 3.5, not 3, to provide full view of Ursa Major and Cassiopeia. (Notice that the Polaris is just above your head!)
