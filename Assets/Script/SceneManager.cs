using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject VirtualScene; // 虛擬場景
    public GameObject RealScene;    // 真實場景
    public GameObject PositionTracker;
    public GameObject Triggers;
    public GameObject EnterButton;
    
    public GameObject[] Exhibitions; // 所有展覽場景

    void Start()
    {
        // close virtual scene & trigger
        VirtualScene.SetActive(false);
        Triggers.SetActive(false);
    }

    // Toggle Passthrough mode (real <-> virtual scene)
    public void TogglePassthrough(bool enable)
    {
        OVRManager.instance.isInsightPassthroughEnabled = enable;
        if (enable)
        {
            // Switch to the real scene
            Triggers.SetActive(false);
            VirtualScene.SetActive(false);
            RealScene.SetActive(true);
            PositionTracker.SetActive(true);
            EnterButton.SetActive(true);
        }
        else
        {
            // Switch to virtual scene
            Triggers.SetActive(true);
            VirtualScene.SetActive(true); 
            RealScene.SetActive(false);
            PositionTracker.SetActive(false);
            EnterButton.SetActive(false);
        }
    }

    // Switch exhibition scenes (index 0, 1, 2, 3) and reset the `VirtualScene` position
    public void ResetExhibition(int index)
    {
        // Reset the `VirtualScene` position
        VirtualScene.transform.localPosition = Vector3.zero;
        VirtualScene.transform.localEulerAngles = Vector3.zero;

        // Switch exhibition scene
        for (int i = 0; i < Exhibitions.Length; i++)
        {
            Exhibitions[i].SetActive(i == index);
        }
    }
}
