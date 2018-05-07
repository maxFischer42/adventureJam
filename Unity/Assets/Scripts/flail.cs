using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flail : MonoBehaviour {

    public GameObject flailObj;
    public bool inRange;
    public float booster;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            var worldMousePosition =
              Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            Vector2 dir = worldMousePosition - transform.position;
            flailObj.GetComponent<Rigidbody2D>().velocity = (dir);

            if (Input.GetMouseButtonDown(0))
            {
                flailObj.GetComponent<Rigidbody2D>().velocity = (dir * booster);
            }

        }
     }






}
  

