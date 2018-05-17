using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossEmit : MonoBehaviour {

    public GameObject player;
    public GameObject Slime;
    public int numOfSlimes;
    public float launchSpeed;
    float timer;
    public float YOffSet;
    public AudioClip aud;
    public float timeTillEmit;
    public float maxSlimes = 15;
	
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= timeTillEmit && numOfSlimes < maxSlimes)
        {
            Vector2 dir = player.transform.position - new Vector3(transform.position.x, transform.position.y + YOffSet);
            GameObject slim = Slime;
            
            GameObject ne = (GameObject)Instantiate(slim, new Vector2(transform.position.x, transform.position.y + YOffSet), Quaternion.identity);
            ne.GetComponent<Rigidbody2D>().velocity = dir * launchSpeed;
            numOfSlimes++;
            GetComponent<AudioSource>().PlayOneShot(aud);
            timer = 0;
        }
	}
}
