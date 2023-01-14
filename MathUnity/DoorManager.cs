using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour 
{
    int doorTypeMagic = AttributeManager.MAGIC;
    int doorTypeInvisible = AttributeManager.INVISIBLE;
    int doorTypeFly = AttributeManager.FLY;
    int doorTypeIntelligence = AttributeManager.INTELLIGENCE;
    int doorTypeCharisma = AttributeManager.CHARISMA;
    void OnCollisionEnter(Collision collision) 
    {
        // OnCollision --> When Other object hit this gameobject
        // If Statement ? It just get the Attribute Int representation and then do the Masking 
        // Here's the example : 
        //  Attr =  1 0 0 1 0
        // Mask =   0 1 0 0 0
        // Result = 0 0 0 0 0 
     if( (collision.gameobject.GetComponent<AttributeManager>.attribute & doorTypeMagic) != 0)  
     {
        // Here we're not disabling the Collider instead we use Trigger to make is passable
        // Reason ? I guess there's problem turning back on the collider
        this.GetComponent<BoxCollider>().isTrigger = true;
     }
    
     else if((collision.gameobject.GetComponent<AttributeManager>.attribute & doorTypeInvisible) != 0) 
     {
        this.GetComponent<BoxCollider>().isTrigger = true;
     }

     else if((collision.gameobject.GetComponent<AttributeManager>.attribute & doorTypeCharisma) != 0) 
     {
        this.GetComponent<BoxCollider>().isTrigger = true;
     }
     else if((collision.gameobject.GetComponent<AttributeManager>.attribute & doorTypeFly) != 0) 
     {
        this.GetComponent<BoxCollider>().isTrigger = true;
     }
     else if((collision.gameobject.GetComponent<AttributeManager>.attribute & doorTypeIntelligence) != 0) 
     {
        this.GetComponent<BoxCollider>().isTrigger = true;
     }
    }

    void OnTriggerExit(Collider other) 
    {
        // We need to shutdown, when the other object have been passed  ! Otherwise 
        // OTHERWISE OTHER OBJECT THAT DOESNT have the criteria CAN IN !
        this.GetComponent<BoxCollider>().isTrigger = false;
    }
    void Start() 
    {

    }


    void Update() 
    {

    }
}