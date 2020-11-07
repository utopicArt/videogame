using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Debug = UnityEngine.Debug;

public class tmpVolumen1 : MonoBehaviour{

    public Slider slider;

    void Update(){
        this.GetComponent<TMP_Text>().text = ((int)Math.Round(slider.value)).ToString();
    }
}