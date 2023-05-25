using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class movment : MonoBehaviour
{
    // Start is called before the first frame update
    //physics of sub
    Rigidbody2D body;
    //verctor that will be used to set velocity
    Vector2 v;
    //all attributes of sub
    attributes arrt;
    public GameObject fuleTxt;
    public GameObject oxygenTxt;

    //indicated wether the sub is moving
    public bool moving = false;
    public bool movingX = false;
    public bool movingY = false;

    //used to keep track of gas
    float gasTimer= 0;
    float TimeMoving = 0;
    float oxygenTimer = 0;



    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        v = new Vector2(0,0);
        arrt = GetComponent<attributes>();

        //get current speed
        arrt.setSpeed(5);
        gasTimer = Time.time;
        fuleTxt.GetComponent<TextMeshProUGUI >().text = "Fule: "+arrt.currentFule.ToString();
        oxygenTxt.GetComponent<TextMeshProUGUI>().text = "Oxygen: "+arrt.currentOxygen.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if(Input.GetKey("w"))
        {
            v = new Vector2(v.x, arrt.getSpeed());
            movingX = true;
        }
        else if(Input.GetKey("s"))
        {
            v = new Vector2(v.x, -arrt.getSpeed());
            movingX = true;
        }
        else
        {
            v = new Vector2(v.x, 0);
            movingX = false;
        }
        
        
        if(Input.GetKey("a"))
        {
            v = new Vector2(-arrt.getSpeed(), v.y);
            movingY = true;
        }
        else if(Input.GetKey("d"))
        {
            v = new Vector2(arrt.getSpeed(), v.y);
            movingY = true;
        }
        else
        {
            v = new Vector2(0, v.y);
            movingY = false;
        }


        moving = movingX || movingY;   
        body.velocity = v;


        //calculate gas usage
        if (moving)
        {
            TimeMoving = TimeMoving + (Time.time - gasTimer);
            gasTimer = Time.time;
        }

        //every 15 seconds of moving will result in a decrease in gas
        if (TimeMoving > 15)
        {
            TimeMoving = 0;
            arrt.setCurrentFule(arrt.currentFule - 1);
            fuleTxt.GetComponent<TextMeshProUGUI>().text = "Fule: "+arrt.currentFule.ToString();
            
        }

        if (Time.time - oxygenTimer > 30)
        {
            oxygenTimer = Time.time;
            arrt.currentOxygen = arrt.currentOxygen - 1;
            oxygenTxt.GetComponent<TextMeshProUGUI>().text = "Oxygen: "+arrt.currentOxygen.ToString();
        }



        


        
        
    }
}
