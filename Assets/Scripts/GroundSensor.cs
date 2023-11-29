using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool _GroundSensor;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           _GroundSensor = true;
        }
    }

        void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           _GroundSensor = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           _GroundSensor = false;
        }
    }
}
