using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        Movement();
#endif
    }
    void Movement()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
#endif
    }
}