using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class mau : MonoBehaviour
{
    public Image hp;
    public TextMeshProUGUI valueText;


    public void thanhhp(int currentValue, int maxValue)
    {
        hp.fillAmount = (float)currentValue / (float)maxValue;
        valueText.text = currentValue.ToString() + " / " + maxValue.ToString();

    }
    
  
}
