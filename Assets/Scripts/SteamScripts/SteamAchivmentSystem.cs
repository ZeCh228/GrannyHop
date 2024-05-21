using UnityEngine;

public class SteamAchivmentSystem : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Steam initialized: " + SteamManager.Initialized);
    }
}
