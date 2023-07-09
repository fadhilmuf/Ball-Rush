using UnityEngine;

public class ColliderPeluru : MonoBehaviour
{
    float speed = 1000f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, speed);
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Block":
                gameObject.SetActive(false);
                speed = 0f;
            break;
            case "Boss":
                gameObject.SetActive(false);
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
