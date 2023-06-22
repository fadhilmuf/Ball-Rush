using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    float broke;
    void Update()
    {
        if(broke == 1f)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if(broke == 2f)
        {
            GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        if(broke == 3f)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "peluru":
                broke++;
                break;
            default:
                break;
        }
    }
}
