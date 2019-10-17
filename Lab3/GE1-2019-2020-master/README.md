# DT228/DT211/DT282/DT508 Games Engines 1 2019-2020

[![Video](http://img.youtube.com/vi/NMDupdv85FE/0.jpg)](http://www.youtube.com/watch?NMDupdv85FE)

## Resources
- [Class Facebook page](https://www.facebook.com/groups/407619519952058/)
- [Course Notes](https://drive.google.com/open?id=1CeMUWjCUa1Ere2fMmtLz5TCL4O136mxj)
- [Assignment](assignment.md)
- [Unity Tutorials](https://unity3d.com/learn/tutorials) 
- [GDC Vault](http://www.gdcvault.com/)
- [Game maths tutorials](http://www.wildbunny.co.uk/blog/vector-maths-a-primer-for-games-programmers/)

## Contact me
* Email: bryan.duggan@dit.ie
* Twitter: [@skooter500](http://twitter.com/skooter500)
* [My website & other ways to contact me](http://bryanduggan.org)


## Previous years courses
- 2018-2019
    - https://github.com/skooter500/GE1-2018-2019
    - https://github.com/skooter500/GE2-2018-2019
- 2017-2018
    - http://github.com/skooter500/GE2-2017-2018
- 2016-2017
	- http://github.com/skooter500/GAI-2017
	- https://github.com/skooter500/GE2-Supplemental-2017
	- https://github.com/skooter500/GE2-LabTest2-2017
	- https://github.com/skooter500/OrbitalRingsSolution
- 2015-2016
    - https://github.com/skooter500/gameengines2015
    - https://github.com/skooter500/BGE4Unity
- 2014-2015
    - https://github.com/skooter500/BGE
    - https://github.com/skooter500/UnitySteeringBehaviours 
- 2013-2014
    - https://github.com/skooter500/XNA-3D-Steering-Behaviours-for-Space-Ships
	
## Assessment Schedule	
- Week 5 - CA proposal & Git repo - 10%
- Week 13 - CA Submission & Demo - 40%

## Week 3 - Vectors & a little bit on Quaternions
- [Slides on vectors & trigonometry](https://drive.google.com/file/d/14pWZNf2Z-FX096wCLHt9t6tLorS323-k/view?usp=sharing)
- [Slides on quaternions](https://drive.google.com/file/d/11-KFbodaAl9dRSs9ljzdDyTDp1QWWnsZ/view?usp=sharing)
- Solution to last weeks lab is in scene2
- CubeMove example is in scene4. Example of dot product of vectors
- [Vectors in Unity](https://docs.unity3d.com/Manual/UnderstandingVectorArithmetic.html)
- [Quaternions in Unity](https://docs.unity3d.com/Manual/UnderstandingVectorArithmetic.html)
- [Unity API Quick reference](unityref.md)

## Lab
### Learning Outcomes
- Use Colliders and Triggers
- Learn how to enable and disable game components
- User lerp & slerp

Your task today is to recreate this system from Infinite Forms:

[![YouTube](http://img.youtube.com/vi/wvu5DuJydKY/0.jpg)](http://www.youtube.com/watch?v=wvu5DuJydKY)

Clone the repo for the course and make sure you start from the master branch. Create a branch for todays solution (call it lab3)

Open up the lab2 scene. There is the red tank following it's circular path (solution from last week). We are going to add a control orb to the red tank so that the player can enter the orb and take control of the red tank.

- Use the orb prefab and attach it at an appropriate position on the red tank
- Add the TankController script to the redtank and set it to be disabled
- Make a script called RotateMe that performs a local rotation and attach it to the orb so that the orb spins by itself
- Add a sphere collider to the orb and set the isTrigger flag to be true
- Add a script called OrbController to the orb and add methods for OnTriggerEnter and OnTriggerStay. OnTriggerEnter gets called on the script whenever the attached collider overlaps with another collider. OnTriggerStay gets called once per frame so long as the collider is still overlapping.
- In OnTriggerEnter you need to:
    - Check you are colliding with the player
    - If so, disable the FPS Controller on the player and enable the TankController script on the tank
    - Disable the EnemyTankController on the Enemy Tank
    - Disable the RotateMe script on the orb
- In OnTriggetStay you need to:    
    - Check you are colliding with the player
    - Lerp the camera position and slerp the camera rotation
    - Check for the space key, if pressed this frame:
        - Disable the TankController on the tank
        - Enable the EnemyTankController
        - Enable the FPS controller
        - Enable the RotateMe script

I may have left out some steps, but you can figure out the rest yourself        

Use the [Unity Quick Reference](unityref.md) and the [Unity online documentation](https://docs.unity3d.com/ScriptReference/) to look up anything you need

## Week 2 - Tank game, trigonometry & vectors
- [Slides](https://drive.google.com/file/d/14pWZNf2Z-FX096wCLHt9t6tLorS323-k/view?usp=sharing)
- [Trigonometry problem set](https://1.cdn.edl.io/IDqRlI8C9dRkoqehbbdHBrcGT6m87gkCQuMKTkp0U7JvHvuG.pdf)

## Lab
### Learning Outcomes
- Build a simple agent with perception
- Develop computation thinking
- Use trigonometry
- Use vectors
- Use the Unity API
- Practice C#

### Instructions

Today you will be making this:

[![YouTube](http://img.youtube.com/vi/kC_W1WBB7uY/0.jpg)](http://www.youtube.com/watch?v=kC_W1WBB7uY)

What is happening:
- The red tank has a script attached that has radius and numWaypoints fields that control the generation of waypoints in a circle around it. It draws sphere gizmos so you can see where the waypoints will be.
- The red tank will follow the waypoints starting at the 0th one and looping back when it reaches the last waypoint.
- The red tank prints the messages using the Unity GUI system to indicate:
    - Whether the blue tank is in front or behind
    - Whether the front tank is inside a 45 degree FOV
    - Use the [Unity reference](unityref.md) to figure out what API's to call!
  
## Week 1 - Introduction
## Lecture
- [Slides](https://drive.google.com/file/d/14pWZNf2Z-FX096wCLHt9t6tLorS323-k/view?usp=sharing)

## Lab

### Learning Outcomes
- Sign up for the class Facebook page
- Find the Unity tutorials
- Test your knowledge of Unity
- Create gameobjects in the scene view
- Create gameobjects from code
- Handle user input
- Use colliders

### Instructions
- Sign up for the [class Facebook page](https://www.facebook.com/groups/407619519952058/)
- Check out the [Unity tutorial videos](https://unity3d.com/learn/tutorials)

Today you can test your knowledge of Unity by making this:

[![YouTube](http://img.youtube.com/vi/B3dSCruPi_s/0.jpg)](http://www.youtube.com/watch?v=B3dSCruPi_s)

What's happening:

- The tank is made from two cubes. The turrent is parented to the body of the tank
- A material is used to color the tank blue
- A TankController script controlls tank movement which can use either a game controller or the keyboard
- The tank can fire bullets, which get removed from the scene after 5 seconds
- The camera will follow the tank in the style of a third person game
- The wall is made procedurally and physically simulated
- The player tank can crash into the wall and the bullets can damage the wall
- The bricks in the wall are randomly coloured

A few additional points

- If you have never used Unity before, start by watching a few of the tutorial videos
- See how far you can get with the lab today, but don't be too concerned if you can't finish it. We will make this project in the class next week together and you will discover the awesome power of Unity game engine