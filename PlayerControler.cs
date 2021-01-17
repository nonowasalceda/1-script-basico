using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    public float horizontalInput;
    public float speed = 9.0f;
    public float xRange = 23.0f;
    public GameObject projectilePrefab;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //el personaje se mueve en el eje de las x sin sobrepasar el escenario de juego
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3 (-xRange,transform.position.y,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3 (xRange,transform.position.y,transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //the player launch the food
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }
    }
}
