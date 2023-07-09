using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    public string sceneName;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SwitchScene);
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
