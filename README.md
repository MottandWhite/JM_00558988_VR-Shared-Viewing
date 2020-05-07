This is a Unity project for testing, with 2 or more users, any significant difference in audio quality, naturalness and speech intelligibility in VR shared viewing experiences.

CONTENT

Provided are all the networking and visual components required to carry out local testing. Photon unity networking has been employed for multiplayer avatar tracking and voice comms, with Google Resonance audio being responsible for spatialisation of speakers and voice along with ambisonic room tone and acoustic room modelling. Broadcast video and audio clips have not been provided in this repository, to avoid any potential implications involving copyright, so video and 5.1 audio must be provided by the researcher. It is recommended that 5.1 audio is separated into stems labelled L C R Ls Rs LFE for implementation on corresponding resonance audio sources within the unity environment.

SETUP

It is recommended that testing using this project is carried out between one participant and one researcher, with a second reseacher present for safety and to monitor potential bugs in Unity. It is advised that the participant uses a build of the experiment in .exe (win) or .dmg (mac) format, while the researcher uses the preview feature in the Unity editor. Depending on equipment it would be most preferable if participants used the Oculus Go or Quest standalone headset, in which case it would be required that a build be produced to support the correct device.

More information on Unity build settings and deployment platforms can be found at https://docs.unity3d.com/Manual/PublishingBuilds.html.

It is essential that participants perform the experiment with a controller, in order to switch freely between spatial and non-spatial audio. Depending on the device, the input of the controller may need to be altered in the AudioSwitcher script as it is currently assigned to operate with an Oculus Rift, Rift S or Quest controller button 'X' and 'A' (OVRInput button "one" and "two").
