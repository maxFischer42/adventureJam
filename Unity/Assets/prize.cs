using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prize : MonoBehaviour {

    private void Awake()
    {
        if (PlayerPrefs.GetInt("won") == 1)
            GetComponent<SpriteRenderer>().enabled = true;
    }
}
