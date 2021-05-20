using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponsRotate : MonoBehaviour
{

    Camera mainCamera;
    Vector3 whereToLook;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        Rotate();

    }


    void Rotate()
    {
#if UNITY_EDITOR || UNITY_STANDALONE

        whereToLook = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40f));
        transform.LookAt(whereToLook);
        transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, 0f, 0f);

#elif UNITY_IPHONE || UNITY_ANDROID
        if(Input.touchCount > 0)
        {
        whereToLook = mainCamera.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 40f));
        }
#endif
    }


}


