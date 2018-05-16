using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour {

    bool kill_;
    public string level;

    // Update is called once per frame
    void Update ()
    {
		if(kill_)
        {
            GetComponent<Light>().intensity += 0.25f;
            if(GetComponent<Light>().intensity > 70)
            {
                SceneManager.LoadScene(level);
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "slime")
        {
            transform.parent.GetComponent<Animator>().runtimeAnimatorController = transform.parent.GetComponent<playerAnimator>().DMG;
            transform.parent.GetComponent<playerAnimator>().enabled = false;
            transform.parent.GetComponent<PlayerMovement>().enabled = false;
            kill_ = true;
        }
    }
}
