using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AttributeManager : MonoBehaviour {

    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;
    public text attributeDisplay;
    public int attributes = 0;

    private void OnTriggerEnter(Collider other) 
    {
            if(other.gameobject.tag == "MAGIC") 
            {
                // Do the Binary Operation
                // Instead do this, Use bit Toggling
                // attributes |= MAGIC;
                // Here what i mean
                attributes ^= MAGIC;
            }

            else if (other.gameobject.tag == "INTELLIGENCE") 
            {
                //Do The Binary Opeartion as wlll
            }

            else if (other.gameobject.tag == "CHARISMA") 
            {
                //Do The Binary Opeartion as wlll
            }
            else if (other.gameobject.tag == "FLY") 
            {
                //Do The Binary Opeartion as wlll
            }
            else if (other.gameobject.tag == "INVISIBLE") 
            {
                //Do The Binary Opeartion as wlll
            }
            else if(other.gameobject.tag == "ANTIMAGIC") 
            {
                // REmovve the Magic
                attributes &= ~MAGIC;
            }

            else if (other.gameobject.tag == "XorosBlessing") 
            {
                // Add Intelligence , magic , and charisma All at once
                attribute = attribute | ( INTELLIGENCE | MAGIC | CHARISMA);
            }
            else if (other.gameobject.tag == "XorosCurse") 
            {
                // remove Intelligence , and magic all at once
                attribute = attribute & ~(INTELLIGENCE | MAGIC);
            }
            else if(other.gameobject.tag == "GodCurse") 
            {
                // You can do this 
                //attribute = attribute & ~( INTELLIGENCE | MAGIC | CHARISMA | INVISIBLE | FLY );
                // or this 
                attribute =0;
            }

    }

    // Integer to represent the Boolean Attributes for characters, max 32 
    int attributes = 0;    
    
    void Start() 
    {

    }

    void Update() 
    {
            // Get the (X,y,z) Value of current gameObject
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);

            //Setting the Attribute Display Location but down on bottom for 50
            attributeDisplay.transform.position = screenPoint + new Vector3(0, -50, 0);

            // Setting up The Text, (Convert to String its for the binary, padding left to expand the binary representation)
            attributeDisplay.text = Convert.ToString(attribute, 2).PadLeft(8,'0');

            //THe OUTPUT : 
            // When the game object get new attribute, there will be an operation !

    }

}
