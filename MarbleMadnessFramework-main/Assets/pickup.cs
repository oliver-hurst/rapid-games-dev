using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "destructable") 
        {
            Destroy(collision.gameObject);
        }
        
    }
    // Start is called before the first frame update

}
