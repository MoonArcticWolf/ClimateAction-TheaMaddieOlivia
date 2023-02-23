using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class portraitChange : MonoBehaviour
{
    Image myImage;
    public Sprite portrait;    
    // Start is called before the first frame update
    void Start()
    {
    
    myImage = GetComponent<Image>();
    }

    // Update is called once per frame
    public void changeImage()
    {
    if(myImage != portrait){
        myImage.sprite = portrait;
    }
}
}
