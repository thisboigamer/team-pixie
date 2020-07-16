using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player");
        {
            print ("Item picked up");
            GameVariable.itemCount += 1;
            Destroy(gameObject);
        }
    }
}
