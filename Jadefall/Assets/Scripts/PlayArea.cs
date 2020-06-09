using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        canvas.SetActive(false);
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "PlaySphere")
        {
            canvas.SetActive(false);
            print("player has re-entered the play area!");
        }
        
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.transform.tag == "PlaySphere")
        {
            canvas.SetActive(true);
            print("player has left the play area!");
        }

    }
}
