using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resources : IResources
{
    //Variables
    public enum ObjectState { New, Damaged, Broken, Destroyed };


    private float objectHealth;
    private ObjectState objectState;


    //getters:Setters methods for variables
    //object Health
    public float getObjectHealth() {
        return objectHealth;
    }
    public void setObjectHealth(float value) {
        objectHealth -= value;
        setObjectState(objectHealth);
    }


    //object state
    public ObjectState getObjectState()
    {
        return objectState;
    }
    public void setObjectState(float value) {

        if (value >= 70)
        {
            objectState = ObjectState.New;
        }
        else if (value > 30)
        {
            objectState = ObjectState.Damaged;
        }
        else if (value > 0)
        {
            objectState = ObjectState.Broken;
        }
        else if (value <= 0)
        {
            
            objectState = ObjectState.Destroyed;
        }
        else
        {
            print("Errors");
        }

    }

    //Global Start/Update Methods
    void Start()
    {
        objectHealth = 100;
        objectState = ObjectState.New;
    }

    
    void Update()
    {
        
    }
}
