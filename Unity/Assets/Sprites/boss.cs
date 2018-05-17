using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {

    public int HP;
    public GameObject star;
    public GameObject death;
    public bossEmit bm;
    float baseTime;

    private void Start()
    {
        baseTime = bm.timeTillEmit;
    }


    // Update is called once per frame
    void Update ()
    {
		if(HP <= 0)
        {
            star.SetActive(true);
            death.SetActive(true);
            PlayerPrefs.SetInt("won", 1);
            Destroy(gameObject);
        }
        switch(HP)
        {
            case 4:
                bm.timeTillEmit = baseTime - (baseTime * 0.2f);
                break;
            case 3:
                bm.timeTillEmit = baseTime - (baseTime * 0.3f);
                break;
            case 2:
                bm.timeTillEmit = baseTime - (baseTime * 0.4f);
                break;
            case 1:
                bm.timeTillEmit = baseTime - (baseTime * 0.5f);
                break;
        }
	}


}
