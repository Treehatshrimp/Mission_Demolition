using UnityEngine;

public class MouseWorldDebug : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        Debug.Log(pos);
    }
}