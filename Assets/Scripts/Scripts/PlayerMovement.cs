using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int speed = 5;
    


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            transform.position = transform.position + ((new Vector3(0, speed, 0) * Time.deltaTime));
           // Debug.Log("Up");
        }
        if (Input.GetKey("s"))
        {
            transform.position = transform.position + ((new Vector3(0, -speed, 0) * Time.deltaTime));
            //Debug.Log("Down");
        }
        if (Input.GetKey("a"))
        {
            transform.position = transform.position + ((new Vector3(-speed, 0, 0) * Time.deltaTime));
            //Debug.Log("Up");
        }
        if (Input.GetKey("d"))
        {
            transform.position = transform.position + ((new Vector3(speed, 0, 0) * Time.deltaTime));
           // Debug.Log("Up");
        }
    }
}
