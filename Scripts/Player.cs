using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 150.0f;
    public Vector2 maxVel = new Vector2(60, 150);
    private Rigidbody2D body2d;
    private CircleCollider2D coll;
    private SpriteRenderer sprite;
    public float jetSpeed = 200.0f;
    public bool standing;
    public float standingThreshold=10f;
    public float airspeedFactor = 0.3f;
    private PlayerController controller;
    private Animator animator;
    private Kill kill;
   
    void Start()
    {
        kill = GetComponent<Kill>();
        body2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        coll = GetComponent<CircleCollider2D>();
       
    }
    void Update()
    {
        if (kill.iskilled == true)
        {
           // print("killed");
            coll.enabled=false;
            animator.SetInteger("AnimState", 3);
        }
        else
        {
            var absVelx = Mathf.Abs(body2d.velocity.x);
            var forceX = 0.0f;
            var forceY = 0.0f;
            var absVely = Mathf.Abs(body2d.velocity.y);
            if (absVely < standingThreshold)
            {
                standing = true;
            }
            else
            {
                standing = false;
            }
            if (controller.moving.x != 0)
            {
                if (absVelx < maxVel.x)
                {
                    float newspeed = speed * controller.moving.x;
                    forceX = standing ? newspeed : (newspeed * airspeedFactor);
                    sprite.flipX = forceX < 0;
                }
                animator.SetInteger("AnimState", 1);
            }
            else
            {
                animator.SetInteger("AnimState", 0);
            }
            if (controller.moving.y != 0)
            {
                if (absVely < maxVel.y)
                {
                    float newspeed = jetSpeed * controller.moving.y;
                    forceY = newspeed;
                }
                animator.SetInteger("AnimState", 2);
            }
            else if (absVely > 0 && !standing)
            {
                animator.SetInteger("AnimState", 3);
            }
            body2d.AddForce(new Vector2(forceX, forceY));
        }
    }
}
