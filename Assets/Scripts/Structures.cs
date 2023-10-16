using UnityEngine;

public class Structures : MonoBehaviour
{
    [SerializeField] GameObject[] Enemies;
    [SerializeField] GameObject[] Orcs;



    private void Start()
    {
        var orcsCount = 0;

        foreach (GameObject enemy in Enemies)
        {
            if (enemy.name.StartsWith("Orc"))
            {
                orcsCount++;
            }
        }

        Orcs = new GameObject[orcsCount];

        var orcsIndex = 0;

        for (int i = 0; i < Enemies.Length; i++)
        {
            if (Enemies[i].name.StartsWith("Orc"))
            {
                Orcs[orcsIndex] = Enemies[i];
                orcsIndex++;
            }
        }
    }
}
