using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyRotate : MonoBehaviour
{

    Vector3 posToLookAt = new Vector3(0f, 0f, 0f);
    Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
       
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        posToLookAt = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));
        transform.LookAt(posToLookAt);
        transform.eulerAngles = new Vector3(0f, transform.localEulerAngles.y, 0f);

#elif UNITY_IPHONE || UNITY_ANDROID

if(Input.touchCount >= 0)
{

       posToLookAt = mainCam.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 100f));

}

#endif
    }
}
