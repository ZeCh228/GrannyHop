using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MyCoolDictionary
{
    [SerializeField] public List<Renderer> renderers;
    [SerializeField] public List<Material> DefaultMaterials;
    [SerializeField] public List<Material> DissolveMaterials;
}
