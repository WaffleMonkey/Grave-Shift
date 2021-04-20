using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hints : MonoBehaviour
{
    public GameObject hintUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("pressed");
            hintUI.SetActive(true);
          
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("pressed b");
            hintUI.SetActive(false);
        }
    }
}
