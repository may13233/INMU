using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter3 : MonoBehaviour
{
    public GameObject Virtualscene;
    public GameObject CenterC;
    public GameObject Ref;
    float PreAngle = 240;
    float AngleSum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("pre" + PreAngle);
            Debug.Log("now" + Ref.transform.localRotation.eulerAngles.y);
            float NowAngle = Ref.transform.localRotation.eulerAngles.y;
            float AngleDif = NowAngle - PreAngle;
            float RedirectAngle = AngleDif/3;
            PreAngle = NowAngle;
            if (Ref.transform.localRotation.eulerAngles.y < 135 && Ref.transform.localRotation.eulerAngles.y >=0 && Mathf.Abs(RedirectAngle) < 40)
            {
                Virtualscene.transform.RotateAround(CenterC.transform.position, new Vector3(0f, 1f, 0f), RedirectAngle);
                PreAngle = NowAngle;
                                
            }
            if (Ref.transform.localRotation.eulerAngles.y < 360 && Ref.transform.localRotation.eulerAngles.y >225 && Mathf.Abs(RedirectAngle) < 40)
            {
                Virtualscene.transform.RotateAround(CenterC.transform.position, new Vector3(0f, 1f, 0f), RedirectAngle);
                PreAngle = NowAngle;
                
                        }
        }

    }
}
