using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    float speed = 0f;
    float broke;
    float decrease = 1f;

    public Slider uiSlider;

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
                uiSlider.value -= decrease;
            break;
        }
    }
}
