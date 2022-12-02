using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHealth : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponrnt<RubyComtroller>();

        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void ()
    {
        
    }
}
