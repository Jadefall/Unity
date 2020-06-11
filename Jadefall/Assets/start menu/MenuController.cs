using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }

    public void SetQuaility()
    {
        SetScreenRes();
    }
    void SetScreenRes()
    {
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (index)
        {
            case "0":
                Screen.SetResolution(1152, 648, true);
                break;
            case "1":
                Screen.SetResolution(1280, 760, true);
                break;
            case "2":
                Screen.SetResolution(1360, 764, true);
                break;
            case "3":
                Screen.SetResolution(1920, 1080, true);
                break;

        }
    }
}

