using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject Virtualscene;
    public GameObject CenterA;
    public GameObject Ref;
    float PreAngle= 0;
    float AngleSum = 0;
    //public bool Enter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("pre" + PreAngle);
        //Debug.Log("now" + Ref.transform.localRotation.eulerAngles.y);
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player") {
         Debug.Log("pre" + PreAngle);
         Debug.Log("now" + Ref.transform.localRotation.eulerAngles.y);
        float NowAngle = Ref.transform.localRotation.eulerAngles.y;
        float AngleDif = NowAngle - PreAngle;
        float RedirectAngle = AngleDif/3;
        PreAngle = NowAngle;
            if (Ref.transform.localRotation.eulerAngles.y >= 45 && Ref.transform.localRotation.eulerAngles.y <= 315 && Mathf.Abs(RedirectAngle) < 40)
        {
            Virtualscene.transform.RotateAround(CenterA.transform.position, new Vector3(0f, 1f, 0f), RedirectAngle);
            
               
                
            }
            
        }
                        
    }

}
