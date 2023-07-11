using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Canvas shop;
    public Button shopbutton;
    public Button exitButton;

    void Start()
    {
        shopbutton = GetComponent<Button>();
        shopbutton.onClick.AddListener(openShop);
    }

    void openShop()
    {
        shop.enabled = true;
    }
}
