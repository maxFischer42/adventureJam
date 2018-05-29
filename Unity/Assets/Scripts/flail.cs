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
            Vector2 dir = worldMousePosition;
            flailObj.transform.SetPositionAndRotation(dir, Quaternion.identity);
         
        }
        if(!inRange && Input.GetKeyDown(KeyCode.R))
        {
            flailObj.transform.SetPositionAndRotation(new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
        }
     }






}
  

