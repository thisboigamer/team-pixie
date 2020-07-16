using System.Collections;
using UnityEngine;

public class door : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (GameVariable.itemCount > 2)
            {
                print("enter");
                Destroy(gameObject);
            }
        }
    }
}
