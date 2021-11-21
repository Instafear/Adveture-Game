using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{
    public float speed=100.0f;
    private Rigidbody2D body2d;
    private void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body2d.velocity = new Vector2(speed * transform.localScale.x,0);
    }
}
