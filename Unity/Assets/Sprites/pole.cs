using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pole : MonoBehaviour {

    public boss Boss;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "flail")
        {
            Boss.HP--;
            Destroy(gameObject);
        }
    }


}
