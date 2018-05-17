using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossCut : MonoBehaviour {

    public GameObject npc;
    public PlayerMovement pm;
    public GameObject bos;
    public GameObject np;

	public void Boss()
    {
        npc.SetActive(false);
        pm.enabled = true;
        bos.SetActive(true);
        np.SetActive(false);
        Destroy(gameObject);
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        npc.SetActive(true);
        pm.enabled = false;
    }

}
