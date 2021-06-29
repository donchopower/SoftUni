using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
	private const float MinZ = -1.7f;
	private const float MaxZ = 12f;
	private const float Speed = 0.2f;
	private const float MinX = -3f;
	private const float MaxX = 3f;

	public static int Health = 5;

	public Slider Healthbar;
	public GameObject GameOverMenu;
	public RoadScript RoadScript;

	//float _horizontalAxis;
	//float _verticalAxis;

	// Use this to move the car forward/backward and left/right
	private Rigidbody _rigidbody;

	void Awake()
	{
		Application.targetFrameRate = 60;
	}

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody>();

	}

	private void OnTriggerEnter(Collider coll)
	{
		// Detect hit with either tag "Health" or tag "Enemy"

		if(coll.tag == "Enemy")
        {
			Health--;
			Healthbar.value--;
        }
		else if(coll.tag == "Health")
        {

			if (Health < 5)
			{
				Health++;
				Healthbar.value++;
			}
        }

	}

	// Update is called once per frame
	void Update()
	{
		if (Health <= 0)
		{
			// GameOver
			RoadScript.RoadSpeed = 0f;
			GameOverMenu.SetActive(true);
		}
        else
        {
            _rigidbody.position = new Vector3(Mathf.Clamp(_rigidbody.position.x + Input.GetAxis("Horizontal") * Speed,MinX, MaxX), _rigidbody.position.y, Mathf.Clamp(_rigidbody.position.z + Input.GetAxis("Vertical") * Speed, MinZ, MaxZ));
			
        }
 


    }
}
