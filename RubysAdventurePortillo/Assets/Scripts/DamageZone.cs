using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnnter2D(Collider2D other)
    {
        RubyController = other.GetComponent<RubyController>();
       

        if (Controller != null)
        {
            Controller.ChangeHeath(-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
