using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resources : ObjectStates, IResources
{
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
        print(objectHealth);
    }


    //object state
    public ObjectState getObjectState()
    {
        return objectState;
    }
    public void setObjectState(float value) {
        //change hard coded values to be a function of maxHealth
        if (value >= 70)
        {
            objectState = ObjectState.New;
        }
        else if (value > 30)
        {
            objectState = ObjectState.Damaged;
        }
        else if (value >= 10)
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
    public virtual void Start()
    {
        //default health of resource to 100 may be overwritten in object class
        objectHealth = 100;
        objectState = ObjectState.New;
    }

    
    void Update()
    {
        
    }
    abstract public int dropMaterial(int value);
}
