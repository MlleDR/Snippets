/// Useful if condition to differentiate whether you are running your game on an Android device or on PC (in Play Mode)
/// This little piece of code frees you from using public user booleans to switch between PC and Android.
if (Input.touchSupported && Application.platform != RuntimePlatform.WebGLPlayer)
{
  // Do something when the game runs on an Android Device.
}

else
{
  // Do something Else when the game runs in Unity Play mode.
}
