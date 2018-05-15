using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour {


    public GameObject part;
    public GameObject destroyed;
    public float speed;
    public Vector2 timr;
    public bool direction;
    float timer;
    float target;

	// Use this for initialization
	void Start () {
        target = Random.Range(timr.x, timr.y);
    }
	
	// Update is called once per frame
	void Update ()
    {

        timer += Time.deltaTime;
        Rigidbody2D rig = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().flipX = !direction;
        if(direction)
        {
            rig.velocity = new Vector2(-speed, 0);
        }
        else if(!direction)
        {
            rig.velocity = new Vector2(speed, 0);
        }
        if(timer >= target)
        {
            timer = 0;
            target = Random.Range(timr.x, timr.y);
            direction = !direction;
        }

            
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "flail")
        {
            GameObject corpse;
            corpse = (GameObject)Instantiate(destroyed, transform);
            corpse.transform.SetParent(null);
          
            Destroy(gameObject);
        }
    }


}
