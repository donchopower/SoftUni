using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour


{

    Camera mainCameraa;
    Vector3 shootFrom = new Vector3(0f, 0f, 0f);
    public GameObject bullet;
    public GameObject leftCannon;
    public GameObject rightCannon;


    // Start is called before the first frame update
    void Start()
    {
        mainCameraa = GameObject.Find("Main Camera").GetComponent<Camera>();
        

    }

    // Update is called once per frame
    void Update()
    {

        shootFrom = mainCameraa.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40f));
       

        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GameObject go = Instantiate(bullet);
            go.transform.position = leftCannon.transform.position;
            go.transform.LookAt(shootFrom);
            go.AddComponent<bullet>();

            go = Instantiate(bullet);
            go.transform.position = rightCannon.transform.position;
            go.transform.LookAt(shootFrom);
            go.AddComponent<bullet>();
        }







}




}




