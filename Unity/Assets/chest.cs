using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour {


    public Sprite close_;
    public Sprite open_;
    public GameObject item_;
    public GameObject dialouge_;
    private bool update_;
    private float timer;
    public GameObject obj1_;
    public GameObject obj2_;
    public Behaviour beh1_;
    public LineRenderer beh2_;
    public Behaviour beh3_;
    public GameObject dis1_;
    public GameObject dis2_;
    public Behaviour deh1_;
    public Behaviour deh2_;
    public Behaviour deh3_;

    private void Update()
    {
        if (!update_) return;
        dialouge_.SetActive(true);
        timer++;
        obj1_.SetActive(true);
        obj2_.SetActive(true);
        beh1_.enabled = true;
        beh2_.enabled = true;
        beh3_.enabled = true;
        if(timer > 400)
        {


            GameObject.Find("Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            enabled = false;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = open_;
            item_.SetActive(true);
            update_ = true;

        }
    }
}
