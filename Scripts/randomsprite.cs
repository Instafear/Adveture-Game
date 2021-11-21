using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomsprite : MonoBehaviour
{
    public Sprite[] sprites;
    public int number=-1;
    void Start()
    { 
       
       if(number >-1 && number<=sprites.Length)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[number-1];
        }
       else
        {
            GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
