using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Ground":
                Debug.Log("Hip");
            break;
            case "Player":
                GetComponent<Collider>().isTrigger = true;
            break;
        }
    }
}
