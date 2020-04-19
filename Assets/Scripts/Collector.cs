using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTrigger2D(Collider2D  Target)
    {
        if(Target.tag == "Bomb" ) 
        {
            Target.gameObject.SetActive(false);
        }

        if( Target.tag == "Fruit")
        {
            Target.gameObject.SetActive(false);
        }
    }
}
