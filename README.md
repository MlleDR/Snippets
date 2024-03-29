# Snippets 
Useful snippets that I often use in my projects and that I'm glad to share. 

They are mostly begginers' code (well, just like me :blush:) but I hope they might help others who, like me, started to learn coding from generous coders' community who shared and continue to share their experience freely.

In addition, please have a look at the use of coding in my personal work here and enjoy ! 

[Sismograffiti and Tagcards](http://lefemmemademoiselle.tumblr.com/)

[DCBL Project channel](https://www.youtube.com/channel/UCUNX8-GVX5Q6I0nTqcFO0LQ)

Feel free to contact me for any questions or advice on improving the snippets posted.


### Javascript folder
- [*RandomToggle.js*](https://github.com/MlleDR/Snippets/blob/master/Javascript/RandomToggle.js) - Method to toggle randomly between two given values.
- [*CreatePointAroundCircle.js*](https://github.com/MlleDR/Snippets/blob/master/Javascript/CreatePointAroundCircle.js) - Method to make an object move around a circle. [Demo with p5 library](https://github.com/MlleDR/point-on-circle).


##


### Unity/C# folder
##### Animation
- [*RotateCameraAroundTarget.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Animation/RotateCameraAroundTarget.cs) - Method to orbit camera (or any object of your choice) around a target. I usually put this script on my Main Camera to orbit (and debug) a specific scene component at runtime. It's also perfect for demos.
- [*ConstantLerp.cs*](https://github.com/MlleDR/Snippets/blob/b3f8662d5cde929fbd08fffb7d1983073558af9c/Unity/CSharp/ConstantLerp.cs) - Constant Vector3.Lerp from A to B with speed
- [*DetectDirectionalRotation.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Animation/DetectDirectionalRotation.cs) - Detect if an object/player is rotating clockwise or anti-clockwise

##### Components
- [*AddComponent_TextMesh.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Components/AddComponent_TextMesh.cs) - Create a TextMesh component in realtime. 

![image](https://user-images.githubusercontent.com/27687330/115968166-b9442500-a536-11eb-870b-69af0c62d741.png)

##### Maths
- [*DistanceFromTarget.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Maths/DistanceFromTarget.cs) - Methods to calculate the distance between two Gameobjects.

##### Camera
- [*OrthoScreenCameraBoundaries.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Camera/OrthoScreenCameraBoundaries.cs) - Some examples of screen positions on an Orthographic camera (Center, TopLeft, TopRight, BottonLeft, BottonRight)

##### Input
- [*CallKeyDownWithDelay.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Inputs/CallKeyDownWithDelay.cs) - Method to trigger a KeyDown (analog or bool) with a given delay. Let you control the rate a button triggers an action.

##### Utilities
- [*MapValueToRange.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Utilities/MapValueToRange.cs) - Method to map a value between a given range.
- [*CallFunctionAtInterval.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Utilities/CallFunctionAtInterval.cs) - Method to call a function at a given interval.
- [*PrintOnlyOnceInUpdateMethod.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Utilities/PrintOnlyOnceInUpdateMethod.cs) - Method that will call a function only Once in the Update() method.
- [*LookAtTarget.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Utilities/LookAtTarget.cs) - Look at a target (seperate XYZ axis)



##



#### Android Device
- [*DetectDevice_PC_Android.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Android/DetectDevice_PC_Android.cs) - Detect easily if your app is running on an Android device or in Play mode in Unity engine. This little piece of code frees you from using public user booleans switched manually between PC and Android.


##


#### Creative Coding
##### Color
- [*XYZ_TO_AdobeRGB.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Color/XYZ_TO_AdobeRGB.cs) - Method that returns an Adobe RGB vector from XYZ coordinates. I created this function to convert my xyz movement to color. You can find [some samples of my work here](https://lefemmemademoiselle.tumblr.com/tagged/dance/chrono/page/4).

##### Canvas
- [*ScreenArray.cs*](https://github.com/MlleDR/Snippets/blob/master/Unity/CSharp/Canvas/ScreenArray.cs) - Get a Screen Array from TopLeft to BottomRight corner with borders and illustrate with spheres on an Orthographic camera.

![image](https://user-images.githubusercontent.com/27687330/117535157-ce1fbe80-aff4-11eb-86b8-e88af15f331e.png)



##

#### 💡 Tips 💡
- **Editor folder** - When using a plugin script that is not an asset from the Package Manager or that you got from the community, for ex this [awesome script for Replacing a Prefab by another](Unity/CSharp/ReplaceWithPrefab.cs), don't forget to put it in a folder called **Editor**. Thus, it will not be compiled when building your game, nor will it prompt errors like **are you missing an assembly reference?**.
More info on Replace With Prefab awesome adventure [*here*](https://forum.unity.com/threads/replace-game-object-with-prefab.24311/).
##
