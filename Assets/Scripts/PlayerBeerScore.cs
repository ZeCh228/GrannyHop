using TMPro;
using UnityEngine;

class PlayerBeerScore : MonoBehaviour 
{
    [SerializeField] int BeerScore;
    [SerializeField] TextMeshProUGUI BeerUI;
    


    public void AddBeer() 
    {
        BeerScore += 1;
        BeerUI.SetText(BeerScore.ToString());
    }

}
