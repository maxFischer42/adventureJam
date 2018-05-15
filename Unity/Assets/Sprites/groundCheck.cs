using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            transform.GetComponentInParent<playerAnimator>().grounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            transform.GetComponentInParent<playerAnimator>().grounded = false;
        }
    }
}
