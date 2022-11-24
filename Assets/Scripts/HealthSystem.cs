using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] int maxHealth = 5;
    int currentHealth;

    void Start(){
        currentHealth = maxHealth;
    }

    void OnParticleCollision(){
        
        Debug.Log(currentHealth);
        if(currentHealth != 0){
            currentHealth--;
        }
        else{
            Destroy(gameObject);
        }
    }

}
