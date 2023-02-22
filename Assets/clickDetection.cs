using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDetection : MonoBehaviour
{
    void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("Mouse Clicked");
		}
	}
}
