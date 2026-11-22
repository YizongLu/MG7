# MG7
## Devlog
There are three private variables in TreeOfBirds. The first is an array which stores all of the Sparrow GameObject except Sparrow_Start. The second is a float which stores the interaction distance that if the distance between sparrow and player is less than it, sparrows will pop out. The third is a Transform variable which stores the Transform Component of Player. These three variables are tunable in the inspector. There is an Update method. In every frame, it loops through the array of birds. I use Vector3.Distance to calculate the distance of Sparrow's position and Player's position, which are two Vector3. If the distance is less than interaction Distance, the Sparrow GameObject will be active and the Sparrow will show up in the Scene.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
