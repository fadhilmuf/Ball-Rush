using UnityEngine;

public class ColliderPeluru : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 1000);
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "+2":
                GetComponent<Collider>().isTrigger = true;
            break;
            default:
                GetComponent<Collider>().isTrigger = true;
            break;
        }
    }
}
