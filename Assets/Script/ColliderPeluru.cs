using UnityEngine;

public class ColliderPeluru : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 1000);
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "block":
                Debug.Log("hit");
            break;
            case "Boss":
                Debug.Log("Hit Boss");
            break;
            default:
                GetComponent<Collider>().isTrigger = true;
            break;
        }
    }
    void OnCollisionExit(Collision other)
    {
        switch (other.gameObject.tag)
        {
            default:
                GetComponent<Collider>().isTrigger = false;
            break;
        }
    }
}
