using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(GameObject.FindObjectOfType<audioReplayer>().gameObject);
	}
	
	
}
