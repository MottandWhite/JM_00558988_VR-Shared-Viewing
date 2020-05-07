using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSwitcher : MonoBehaviour
{
    public AudioMixerSnapshot stereo;
    public AudioMixerSnapshot spatialised;
    public TextMesh text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.One))
        {
            stereo.TransitionTo(.01f);
            text.text = "Audio Type B";
        }

        if(OVRInput.Get(OVRInput.Button.Two))
        {
            spatialised.TransitionTo(.01f);
            text.text = "Audio Type A";
        }
    }
}
