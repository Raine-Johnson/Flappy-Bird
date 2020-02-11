using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltWithYVector : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        float angle = Vector3.Angle(Vector3.right, rigidbody.velocity);
        if (rigidbody.velocity.y < 0)
        {
            angle = -angle;
        }

        transform.eulerAngles = new Vector3(90, 180, angle);
    }
    
}
