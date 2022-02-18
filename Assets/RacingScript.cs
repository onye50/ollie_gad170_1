using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{

    int laps = 0;

    float curLapProgress = 0f;
    float reqLapProgress = 100.0f;

    float speed = 10.0f;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GainProgress(speed);
        }
    }

    public void GainProgress(float progress)
    {
        curLapProgress += progress;
        Debug.Log("Gained " + progress + " progress");
        Debug.Log("Total current progress is now: " + curLapProgress);
        CheckProgress(curLapProgress);
    }

    public void CheckProgress(float progress)
    {
        if(progress >= reqLapProgress)
        {
            LapCompleted();
            Debug.Log("reached the required progress!);");
        }
    }

    public void LapCompleted()
    {
        //update laps
        laps++;
        //update curProgress
        curLapProgress = 0f;
        //update reqProgress
        reqLapProgress *= 1.1f;
        //update speed
        speed *= 1.1f;
        Debug.Log("Completed " + laps + " laps");
    }
}
