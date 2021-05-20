using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    float timeOut = 2;
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Time.deltaTime * speed);

        timeOut -= Time.deltaTime;
        if (timeOut <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
