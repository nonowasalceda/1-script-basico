using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutofBounds : MonoBehaviour
{
    public float upBounds = 30.0f;
    public float downBounds = -30.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if(transform.position.z > upBounds)
       {
           Destroy(gameObject);
       }
       else if(transform.position.z < downBounds) 
       {
          Debug.Log("Game Over");
          Destroy(gameObject);
       }

 
    }
}
