using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDetection : MonoBehaviour
{
	void Update() {
		canvasClick.SetActive(true);
	}
	public GameObject canvasClick;
    void OnMouseDown()  {
		Debug.Log("mouse clicked");
		FindObjectOfType<DialogueManager>().displayNextSentence();
	}
}
