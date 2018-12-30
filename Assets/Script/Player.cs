using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public float maxHealth, maxThirst, maxHunger, maxOxygen;
    public float thirstIncreaseRate, hungerIncreaseRate, oxygenDecreaseRate;
    private float health, thirst, hunger,oxygen;

    //add variable for all actions to allow for rebindings?



    public bool dead;
    //Functions
    public void Start()
    {
        dead = false;
        health = maxHealth;
    }
    public void Update()
    {
        if (!dead)
        {
            thirst += thirstIncreaseRate * Time.deltaTime;
            hunger += hungerIncreaseRate * Time.deltaTime;
            oxygen -= oxygenDecreaseRate * Time.deltaTime;

        }
        if (thirst >= maxThirst || hunger >= maxHunger || oxygen <= 0)
            Die();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //print("here");
        //print(collision.gameObject.name);
        
    }
    public void Die()
    {
        dead = true;
    }

}
