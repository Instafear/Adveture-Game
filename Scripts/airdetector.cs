using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airdetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag=="air")
        {
            print("air detected");
            transform.parent.gameObject.transform.localScale = new Vector3(transform.parent.gameObject.transform.localScale.x * -1, transform.parent.gameObject.transform.localScale.y, transform.parent.gameObject.transform.localScale.z);
        }
    }
}
