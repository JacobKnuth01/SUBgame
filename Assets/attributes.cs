using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attributes : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxFule;
    public int currentFule;
    
    public int maxOxygen;
    public int currentOxygen;

    public bool underWater = true;
    int speed;



    public float getFule()
    {
        return currentFule / maxFule;
    }
    public float getOxygen()
    {
        return currentOxygen / maxOxygen; 
    }

    public int getSpeed()
    {
        return speed;
    }
    public void setCurrentFule(int amount)
    {
        this.currentFule = amount;
    }
    public void setCurrentOxygen(int amount)
    {
        this.currentOxygen = amount;
    }

    public void setMaxFule(int max)
    {
        this.maxFule = max;
    }
    public void setMaxOxygen(int max)
    {
        this.maxOxygen = max;
    }
    public void setSpeed(int speed)
    {
        this.speed = speed;
    }
    
}
