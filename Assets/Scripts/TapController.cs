using UnityEngine;

public class TapController : MonoBehaviour
{
    public void OnTap()
    {
        EconomyManager.Instance.AddMeat(1);
    }
}
