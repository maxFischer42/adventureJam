using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimator : MonoBehaviour {

    public Animator anim;
    private Rigidbody2D rig;
    public bool orb_;
    public RuntimeAnimatorController Idle;
    public RuntimeAnimatorController Move;
    public RuntimeAnimatorController DMG;
    public RuntimeAnimatorController Orb;
    public bool grounded;
    public bool isDamaged;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isDamaged) return;

        float x = rig.velocity.x;
        if(grounded && x != 0)
        {
            anim.runtimeAnimatorController = Move;
        }
        else
        {
            anim.runtimeAnimatorController = Idle;
        }



        
	}
}
