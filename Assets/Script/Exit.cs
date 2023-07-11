using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Canvas shop;
    public Button exitButton;

    void Start()
    {
        exitButton = GetComponent<Button>();
        exitButton.onClick.AddListener(exitShop);
    }

    void exitShop()
    {
        shop.enabled = false;
    }
}
