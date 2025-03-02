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
        // 預設關閉虛擬場景 & 觸發器
        VirtualScene.SetActive(false);
        Triggers.SetActive(false);
    }

    // 切換 Passthrough 模式（真實 <-> 虛擬場景）
    public void TogglePassthrough(bool enable)
    {
        OVRManager.instance.isInsightPassthroughEnabled = enable;
        if (enable)
        {
            // 切換到真實場景
            Triggers.SetActive(false);
            VirtualScene.SetActive(false); // `AdjustButton` 也會隨 `VirtualScene` 一起隱藏
            RealScene.SetActive(true);
            PositionTracker.SetActive(true);
            EnterButton.SetActive(true);
        }
        else
        {
            // 切換到虛擬場景
            Triggers.SetActive(true);
            VirtualScene.SetActive(true); // `AdjustButton` 也會隨 `VirtualScene` 一起顯示
            RealScene.SetActive(false);
            PositionTracker.SetActive(false);
            EnterButton.SetActive(false);
        }
    }

    // 切換展覽場景（index 0, 1, 2, 3），並重置 `VirtualScene` 位置
    public void ResetExhibition(int index)
    {
        // 重置 `VirtualScene` 位置
        VirtualScene.transform.localPosition = Vector3.zero;
        VirtualScene.transform.localEulerAngles = Vector3.zero;

        // 切換展覽場景
        for (int i = 0; i < Exhibitions.Length; i++)
        {
            Exhibitions[i].SetActive(i == index);
        }
    }
}
