***Unity Graphics / Scene Setup:***

Player Settings --> Change color space to Linear

Change shadow resolution and distance as needed.

Main Camera rendering path:  --> Desktop App --> Deferred
			                 --> Mobile App  --> Forward

Post Processing:
--> Asset store --> Post Processing Stack --> Import

Add "post processing behavior" script to main camera.
	--> right click in project panel --> "Create Post Processing Profile"
			--> Add Eye Adaption, Vignette, Motion Blur, and Ambient Occlusion
			--> adjust as neccesarry 

Need reflection probe for glass material

All Geometry should have unwrapped UVs for Light Baking.
________________________________________________________________________________

To Bring in Geometry from Revit..

Unwrap UV with 3dS Max for import into Game Engine:

To setup in 3DS Max.. Need to create a toolbar.

Settings tab at right.. run Max script.. Run SteamRoller Script

Setup:
Customize --> Customize User Interface --> Toolbars tab -->
--> Should see SteamRoller under Action. --> click New to create new toolbar -->
--> name new toolbar SteamRoller --> click OK. --> should see toolbar pop-up. --> 
--> Drag SteamRoller Script from under Action into the new Toolbar. --> Dock the toolbar
anywhere... Should be all set.

Using SteamRoller:
1. Export FBX from Revit
2. Import FBX into 3DS Max
3. grab all geometry and convert from Editable Mesh to Editable Poly.
4. If all geometry looks clean, Run SteamRoller Script. Then Export FBX
5. If geometry does not convert to Editable Poly cleanely.. (look at furniture)
	- ctrl-z to get back to un-converted editable mesh
	- get all edges of geometry --> click Make Visible
	- get all verticies of geometry --> click Weld with threshold of .001 
	- Run the script.
5. Export FBX
6. Import into Unity
