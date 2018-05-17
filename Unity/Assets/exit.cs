using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
        Debug.Log("Exit");
    }
}
