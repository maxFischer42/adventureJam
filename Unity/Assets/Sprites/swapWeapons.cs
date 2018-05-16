using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapWeapons : MonoBehaviour {
    public bool selected = true;

    [Header("Grapple stuff")]
    public LineRenderer lr;
    public RopeSystem rs;
    public GameObject crosshair;
    public GameObject hookObj;

    [Header("Flail stuff")]
    public flail fl;
    public GameObject flObj;


	
	// Update is called once per frame
	void Update () {
		if(selected && Input.GetKeyDown(KeyCode.Q))
        {
            lr.enabled = true;
            rs.enabled = true;
            crosshair.SetActive(true);
            hookObj.SetActive(true);

            fl.enabled = false;
            flObj.SetActive(false);
            selected = false;
        }
        if (!selected && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("Player").GetComponent<RopeSystem>().ResetRope();
           lr.enabled = false;
            rs.enabled = false;
            crosshair.SetActive(false);
            hookObj.SetActive(false);

            fl.enabled = true;
            flObj.SetActive(true);
            selected = true;

        }
    }
}
