using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public float speed = 2.0f;
    public bool isSwinging;
    public float jumpSpeed = 3f;

    private Rigidbody2D rig;
    private bool groundCheck;
    private float jumpInput;
    private bool isJumping;


    // Use this for initialization
    void Start () {
        rig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        var halfHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
        groundCheck = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - halfHeight - 0.04f), Vector2.down, 0.025f);

        move(Input.GetAxisRaw("Horizontal"));








        if (!groundCheck) return;

        isJumping = jumpInput > 0f;
        if (isJumping)
        {
            rig.velocity = new Vector2(rig.velocity.x, jumpSpeed);
        }
    }

    void move(float input)
    {
        rig.AddForce(new Vector2(input * speed, 0));
    }
}
