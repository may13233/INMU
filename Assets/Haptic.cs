using Oculus.Haptics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Haptic : MonoBehaviour
{
    // Start is called before the first frame update
    public HapticClip wave;
    private HapticClipPlayer player;
    public GameObject groundLight;

    void Awake()
    {
        player = new HapticClipPlayer(wave);
        player.isLooping=true;
    }

    public void PlayHapticClip1()
    {
        player.Play(Controller.Right);
    }

    /*public void PlayHapticClip2()
    {
        // Setting a new clip will stop the current playback
        player.clip = clip2;
        // Let's start the player again with the new clip loaded
        player.Play(Controller.Left);
    }*/

    public void StopHaptics()
    {
        player.Stop();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "handlebottom")
        {
            PlayHapticClip1();
            groundLight.SetActive(true);
        }
                
    }
    void OnTriggerExit(Collider other)
    {

        if (other.tag == "handlebottom")
        {
            StopHaptics();
            groundLight.SetActive(false);
        }

    }

}
