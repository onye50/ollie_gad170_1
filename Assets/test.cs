using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //variables up top
    /* 
     multi line!!!! wowow!!
     */

    public int fuel = 100;
    public int laps;
    public float lapProgress;
    public float reqLapProgress = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check how much fuel player has
        //if player has more than 0 fuel, lets go!
        if (fuel > 0)
        {
            //we have fuel
            //increase our progress and decrease our fuel
            lapProgress += 5; //increase by 5
            fuel--; //decrease by 1
        }
        else
        {
            //we dont have fuel
            Debug.Log("We've run out of fuel, stupid");
              
        }


        //is our current progress = to or higher than the reuired progress
        if(lapProgress >= reqLapProgress)
        {
            //if yes, increase our lap count and reset our current progress
            laps++; //increase laps by 1
            lapProgress = 0; //reset our lap progress
        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Completed Laps: " + laps);

    }
}
