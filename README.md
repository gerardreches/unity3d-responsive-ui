# ResponsiveUI.cs
A simple C# script which allows your gameobjects to be responsively resized on runtime.

## Warning
This script needs to be attached to a gameobject with a Rect Transform component.

If no Rect Transform is found, the script will show a warning in console.

##How to use it
1. Attach the script to the gameobject with a Rect Transform component that you want to be resized.
2. On inspector, set *Main Axis*, *Resize Units* and *Size* to the values you want.
3. If you want to set a maximum size for the cross axis, active *Limit Cross Axis* and set the variables behind it.
4. Play your scene and the gameobject will be resized on start.
