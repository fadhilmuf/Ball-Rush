using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    float speed = 5f;
    float broke;

    void Update()
    {
        transform.position += -Vector3.forward * speed * Time.deltaTime;

        if(broke == 3f)
        {
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
            case "Player":
                SceneManager.LoadScene(0);
            break;
        }
    }
}
