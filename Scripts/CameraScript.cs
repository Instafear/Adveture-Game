using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraScript : MonoBehaviour
{
    public GameObject target;
  //  private Transform t;
    public float size = 4.0f;
   // public Kill kill;
    public bool stop = false;
    private void Awake()
    {
        GetComponent<Camera>().orthographicSize = Screen.height /size;
      //  kill = GetComponent<Kill>();
    }
    void Start()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }
}

