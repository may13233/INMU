using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothRotation : MonoBehaviour
{
    public Transform target;
    float smooth = 0.3f;
    float distance = 5.0f;
    float yVelocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yAngle = Mathf.SmoothDampAngle(transform.localEulerAngles.y, target.localEulerAngles.y, ref yVelocity, smooth);
        transform.localEulerAngles = new Vector3(0, yAngle, 0);
    }
}
