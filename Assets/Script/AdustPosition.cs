using UnityEngine;
using UnityEngine.UI;

public class AdjustPosition : MonoBehaviour
{
    public GameObject VirtualScene;
    public GameObject RealScene;
    public GameObject PositionTracker;
    public GameObject Triggers;
    public GameObject EnterButton;
    public GameObject AdjustButton;

    void Start()
    {
        // 綁定按鈕點擊事件
        EnterButton.GetComponent<Button>().onClick.AddListener(ActivatePassthroughMode);
    }

    public void ActivatePassthroughMode()
    {
        OVRManager.instance.isInsightPassthroughEnabled = true;
        Triggers.SetActive(false);
        VirtualScene.SetActive(false);
        RealScene.SetActive(true);
        PositionTracker.SetActive(true);
        EnterButton.SetActive(true);
        AdjustButton.SetActive(false);
    }
}
