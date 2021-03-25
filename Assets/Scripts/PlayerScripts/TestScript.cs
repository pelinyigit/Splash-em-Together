using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Vector3 startPos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           startPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(startPos.x,0,transform.position.z));
            transform.position = Vector3.Lerp(transform.position,lastPos,Time.deltaTime);
        }
    }

}
