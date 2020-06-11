using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseHealthMeter : MonoBehaviour
{

    public Color[] color;
    public Image hpImg;
    public HouseHealth HouseHealth;



    // Update is called once per frame
    void Update()
    {
        float f = HouseHealth.health / 500f;
        hpImg.fillAmount = f;
        if (f > 0.83)
        {
            hpImg.color = color[0];
        }
        else if (f > 0.66)
        {
            hpImg.color = color[1];
        }
        else if (f > 0.49)
        {
            hpImg.color = color[2];
        }
        else if (f > 0.32)
        {
            hpImg.color = color[3];
        }
        else if (f > 0.15)
        {
            hpImg.color = color[4];
        }
        else if (f > 0.01)
        {
            hpImg.color = color[5];
        }



    }
}
