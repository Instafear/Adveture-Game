using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public Vector2 killforce=new Vector2(0,3000);
    public bool iskilled = false;
    public CameraScript cam;
    private void Awake()
    {
        iskilled = false;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D target1)
    {
        if(target1.gameObject.tag=="Deadly")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(killforce);
            cam.target = target1.gameObject;            
            iskilled = true;
        }
    }
}
