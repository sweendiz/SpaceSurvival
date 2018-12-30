using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceRock : Resources
{
    private float damageTaken = 0;
    // Update is called once per frame
    void Update()
    {
        //Maybe move this to abstract class? will resolve private objectstate issue... Would have to override?
       

    }

    private void OnTriggerStay(Collider collider)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //move this to variable declaration.
            ObjectState objectState = getObjectState();
            //damage taken will be dependent of character and equipement
            damageTaken = 10; //base 10 for now.
            setObjectHealth(damageTaken);
            //change object Model
            if (objectState == ObjectState.New)
            {
                print("new Rock");
            }
            else if (objectState == ObjectState.Damaged)
            {
                print("Damaged Rock");
            }
            else if (objectState == ObjectState.Broken)
            {
                print("Broken Rock");
            }
            else if (objectState == ObjectState.Destroyed)
            {
                gameObject.SetActive(false);
                print("Destroyed Rock");
            }
            else
            {
                print("error");
            }
        }

    }
}

