using DissolveExample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolvePortal : MonoBehaviour
{
    [SerializeField] Material Material;
    [SerializeField] Vector3 DefaultDissolveOffset;
    [SerializeField] Vector3 TargetDissolveOffset;
    [SerializeField] float TimeDissolveOffset;


    private void Start()
    {
        Material.SetVector("_DissolveOffest", DefaultDissolveOffset);
    }


    void Update()
    {
       var DissolveOffset = Vector3.Lerp(DefaultDissolveOffset, TargetDissolveOffset, TimeDissolveOffset);
        Material.SetVector("_DissolveOffest", DissolveOffset);
    }
}
