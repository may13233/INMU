using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaptofloor : MonoBehaviour
{
    public GameObject tracker;
                // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(tracker.transform.position.x, 0, tracker.transform.position.z);
        gameObject.transform.eulerAngles = new Vector3(0, tracker.transform.eulerAngles.y, 0);
    }
}
