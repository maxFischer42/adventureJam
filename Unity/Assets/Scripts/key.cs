using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Key",PlayerPrefs.GetInt("Key") + 1);
            Destroy(gameObject);
        }
    }

}
