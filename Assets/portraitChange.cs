using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class portraitChange : MonoBehaviour
{
    private Image myImage;
    public Sprite portrait;    

    void Start()
    {
    myImage = GetComponent<Image>();
    }

    public void changeImage(Sprite portrait)
    {
    myImage.sprite = portrait;
    }
}

