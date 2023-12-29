using DissolveExample;
using System.Collections;
using UnityEngine;

public class DissolvePortal : MonoBehaviour
{
    [SerializeField] Vector3 DefaultDissolveOffset;
    [SerializeField] Vector3 TargetDissolveOffset;
    [SerializeField] float TimeToDissolve;
    [SerializeField] TrailRenderer DestroyTrail;
    private float TimeDissolvePassed;
    [SerializeField] bool AllowedToDissolve = false;
    [SerializeField] MyCoolDictionary MyCoolDictionary;

    private void Start()
    {   
        for (int i = 0; i < MyCoolDictionary.DissolveMaterials.Count; i++) 
        {
            MyCoolDictionary.DissolveMaterials[i].SetVector("_DissolveOffest", DefaultDissolveOffset);
        }

        for (int i = 0; i < MyCoolDictionary.renderers.Count; i++)
        {
            MyCoolDictionary.renderers[i].material = MyCoolDictionary.DefaultMaterials[i];
        }
    }


    void Update()
    {
        if (AllowedToDissolve == true)
        {
            Dissolve();
        }
    }


    private void Dissolve()
    {
        TimeDissolvePassed += Time.deltaTime;
        var DissolveOffset = Vector3.Lerp(DefaultDissolveOffset, TargetDissolveOffset, TimeDissolvePassed / TimeToDissolve);

        for (int i = 0; i < MyCoolDictionary.DissolveMaterials.Count; i++)
        {
            MyCoolDictionary.DissolveMaterials[i].SetVector("_DissolveOffest", DissolveOffset);
        }
        
    }


    public void StartDissolve() 
    {
        AllowedToDissolve = true;
        DestroyTrail.enabled = false;

        for(int i = 0; i<MyCoolDictionary.renderers.Count; i++) 
        {
            MyCoolDictionary.renderers[i].material = MyCoolDictionary.DissolveMaterials[i];
        }
    }
}
