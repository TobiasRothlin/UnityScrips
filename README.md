# UnityScrips

This is a small collection of usefull scrips for Unity.

## Folder Cam
In this folder there are two scrips to apply to a camera object. 

### LinkDollyToObject.cs
```
target        -> is a gameObject to which the camera will be linked
smoothness    -> is how smooth the camera will follow the target
```
This script lets the camera follow the target object with a constant offet. This offset is set by placeing the camera in a certain distanz away from the targt.
The movement simulates a dolly move. 

### LinkPanTiltToObject.cs
```
target        -> is a gameObject to which the camera will be linked
smoothness    -> is how smooth the camera will follow the target
```
This script keeps the Camera stationary and locks the camera to the target by paning and tilting it. This movement simulates a camera on a tripod. 
