using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    [SerializeField] int currentHealth;

    void Start(){
        currentHealth = maxHealth;
    }

    void OnParticleCollision(GameObject other){
        if(currentHealth != 1){
            currentHealth--;
        }
        else{
            Destroy(gameObject);
        }
    }

    

    

}
