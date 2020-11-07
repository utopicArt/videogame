using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

/*
    Archivo de configuración del valor de brillo
    using Debug = UnityEngine.Debug;
*/
public class tmpBrillo : MonoBehaviour{

    public Slider mainSlider;
    
    void Update(){
        this.GetComponent<TMP_Text>().text = ((int)Math.Round(mainSlider.value)).ToString();
    }
}