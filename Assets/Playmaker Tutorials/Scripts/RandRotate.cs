using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandRotate : MonoBehaviour
{
    int rotAmount;

    public void RandRotCube()
    {
        rotAmount = Random.Range(-40, 40);
        print(rotAmount);

        transform.rotation = Quaternion.Euler(0, rotAmount, 0);
    }
}
