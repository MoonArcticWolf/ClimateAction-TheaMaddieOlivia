using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class beginTutorial : MonoBehaviour
{
    public GameObject dialogueTriggerObject;
    // Start is called before the first frame update
    void Start(){
        Invoke("tutorial", 0.5f);
    }
    void tutorial()
    {
        Debug.Log("tutorial begins");
        DialogueTrigger test = dialogueTriggerObject.GetComponent<DialogueTrigger>();
        test.triggerDialogue();
    }

}
