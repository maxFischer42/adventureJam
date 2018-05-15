using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
    public RuntimeAnimatorController anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && PlayerPrefs.GetInt("Key") > 0)
        {
            PlayerPrefs.SetInt("Key", PlayerPrefs.GetInt("Key") - 1);
            GetComponent<Animator>().runtimeAnimatorController = anim;
            Destroy(gameObject, 0.4f);
        }
    }
         

}
