using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPS : MonoBehaviour
{
    public int Level; //"laps" variable

    public float curXP; //curlapprogress
    public float reqXP; //reqlapprogress

    //stats variables (to be tracked and modified upon level up)
    public float health;
    public float attack;
    public float defense;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialStats()
    {
        //Initialize stats, level, xp, reqxp, etc

    }

    public void Interaction(int exp)
    {
        //an interaction called by a button press
    }

    public void GainXP(int amount) //gainprogress
    {
        //increase our current xp

    }

    public void LevelUp() //completedlap
    {
        //increase our level
    }

    public void IncreaseStats()
    {
        //Improve our stats
    }
   
}
