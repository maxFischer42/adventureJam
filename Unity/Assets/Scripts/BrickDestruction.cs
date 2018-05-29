using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestruction : MonoBehaviour {

    public Sprite halfpercent;
    public float hp;
    private SpriteRenderer sprt;
    private float currentHP;

    private void Start()
    {
        sprt = GetComponent<SpriteRenderer>();
        currentHP = hp;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "flail")
        {
            currentHP--;
            if(hp / 2 >= currentHP)
            {
                sprt.sprite = halfpercent;
            }
            if(0>= currentHP)
            {
                Destroy(gameObject);
            }
        }
    }


}
