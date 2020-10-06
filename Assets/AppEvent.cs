using UnityEngine;
public class AppEvent : MonoBehaviour
{
    public void OnEventJson(string json)
    {
        Debug.Log("OnEventJson: " + json);
    }
}