using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OVRPlugin;

public class followhand : MonoBehaviour
{
    public GameObject hand;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hand.transform.localRotation.eulerAngles.x);
        if ( hand.transform.localRotation.eulerAngles.x > 280)
        {
             Target.SetActive(true);
            Target.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y, hand.transform.position.z);
        }
        else
        {
            Target.SetActive(false);

        }



    }
}
