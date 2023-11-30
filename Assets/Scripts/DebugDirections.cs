using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDirections : MonoBehaviour
{
    public List<Vector3> StartDirections = new List<Vector3>();
    public List<Vector3> EndDirections = new List<Vector3>();
    public static DebugDirections Instance;

    private void Start()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        for (int i = 0; i < StartDirections.Count; i++) 
        {
            Debug.DrawRay(StartDirections[i], EndDirections[i], Color.red);
        }
    }
}
