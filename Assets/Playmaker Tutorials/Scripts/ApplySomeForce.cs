using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplySomeForce : MonoBehaviour
{

    // Update is called once per frame
    public void ApplyForce(float UserForce)
    {
        Debug.Log("jumpForce :" + UserForce);
        GetComponent<Rigidbody>().AddForce(0, UserForce, 0);
    }
}
