using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public TextMeshProUGUI meatText;

    private void Update()
    {
        meatText.text = "Carne: " + EconomyManager.Instance.meat;
    }
}
