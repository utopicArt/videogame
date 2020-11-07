using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class TestingKeys : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Click!");
		}
		if (Input.GetMouseButton(0))
		{
			Debug.Log("Click liberado!");
		}
		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log("Click liberado 2!");
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Salto");
		}

		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("Salto");
		}

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		if (horizontal < 0f || horizontal > 0f)
		{
			Debug.Log("Eje horizontal " + horizontal);
		}
		if (vertical < 0f || vertical > 0f)
		{
			Debug.Log("Eje vertical " + vertical);
		}
	}
}
