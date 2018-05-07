using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePosCol : MonoBehaviour {

    public flail bool_;


    public void Update()
    {
     //   var worldMousePosition =
     //        Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
      //  transform.SetPositionAndRotation(worldMousePosition, Quaternion.identity);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "mouseRange")
        {
            bool_.inRange = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "mouseRange")
        {
            bool_.inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "mouseRange")
        {
            bool_.inRange = false;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
