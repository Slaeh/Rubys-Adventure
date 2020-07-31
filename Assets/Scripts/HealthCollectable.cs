using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    void onTriggerEnter2D(Collider2D other){
        ControlRuby controller = other.GetComponent<ControlRuby>();

        if(controller != null){
            if(controller.health < controller.maxHealth){
            controller.changeHealth(1);
            Destroy(gameObject);
            }
        }
    }
}
