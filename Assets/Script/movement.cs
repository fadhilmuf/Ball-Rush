using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Text skor;
    public Canvas failed;
    public ParticleSystem failedParticle;

    public MeshRenderer meshRenderer;
    
    float speed = 2f;
    float speedForward = 5f;
    float speedBullet = 5000f;

    int score;
    
    public GameObject bulletPrefab;

    public float spawnDistance = 1.0f;

    void Update()
    {   
        //forward
        transform.Translate(transform.forward * speedForward * Time.deltaTime);
        
        //movement
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);

        //skor UI
        skor.text = score.ToString();

        //reloadLevel
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ReloadLevel();
        }

        //shoot
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(0 < score)
            {
                score--;
                Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;
                Quaternion spawnRotation = transform.rotation;
                Instantiate(bulletPrefab, spawnPosition, spawnRotation);
            }
        }
    }

    void OnCollisionEnter(Collision other) //when object collide to non trigger object
    {
        GameObject player = other.gameObject;

        switch (other.gameObject.tag)
        {
            case "Block":
                Hit();
            break;
            case "Boss":
                Hit();
            break;
            case "x2":
                kali2();
            break;
            case "x4":
                kali4();
            break;
            case "x7":
                kali7();
            break;
            case ":2":
                bagi2();
            break;
            case ":4":
                bagi4();
            break;
            case ":10":
                bagi10();
            break;
            case "+2":
                tambah2();
            break;
            case "+6":
                tambah6();
            break;
            case "+20":
                tambah20();
            break;
            case "-1":
                kurang1();
            break;
            case "-5":
                kurang5();
            break;
            case "-16":
                kurang16();
            break;
        }
    }

    void Hit()
    {
        failed.enabled = true;
        speedForward = 0f;
        speed = 0f;
        failedParticle.Play();
        meshRenderer.enabled = false;
    }
    //so i create scoring manually because i'm dumb and my brain so smolll:(
    private void tambah2()
    {
        score += 2;
    }
    private void tambah6()
    {
        score += 6;
    }
    private void tambah20()
    {
        score += 20;
    }
    private void kali2()
    {
        score *= 2;
    }
    private void kali4()
    {
        score *= 4;
    }
    private void kali7()
    {
        score *= 7;
    }
    private void bagi2()
    {
        score /= 2;
    }
    private void bagi4()
    {
        score /= 4;
    }
    private void bagi10()
    {
        score /= 10;
    }
    private void kurang1()
    {
        score -= 1;
    }
    private void kurang5()
    {
        score -= 5;
    }
    private void kurang16()
    {
        score -= 16;
    }

    void Crash()
    {
        ReloadLevel();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
