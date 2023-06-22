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
            case "Player":
                GetComponent<SphereCollider>().isTrigger = true;
            break;
            case "Block":
                GetComponent<SphereCollider>().isTrigger = true;
            break;
        }
    }
}
