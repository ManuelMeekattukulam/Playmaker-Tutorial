using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandNumButton : MonoBehaviour
{
    PlayMakerFSM RandNumFSM;

    void Start()
    {
        RandNumFSM = GameObject.Find("GUITEXT_RandNum").GetComponent<PlayMakerFSM>();
    }

    public void OnGUI()
    {
        if (GUI.Button (new Rect (295, 145, 75, 40), "Rand"))
	{
		RandNumFSM.Fsm.Event("set_number");
	}
    }
}
