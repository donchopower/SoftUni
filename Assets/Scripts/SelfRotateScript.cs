using UnityEngine;

public class SelfRotateScript : MonoBehaviour
{
	private float _rotateSpeed = 60f;

    // Update is called once per frame
    void Update()
    {
     
        transform.Rotate(0f, _rotateSpeed * Time.deltaTime, 0f);
    }
}
