using TMPro;
using UnityEngine;

class PlayerBeerScore : MonoBehaviour 
{
    [SerializeField] int BeerScore;
    [SerializeField] TextMeshProUGUI BeerUI;
    [SerializeField] Animation BeerUIanimation;
    [SerializeField] int BeerCountToPlayAnimation;

    public void AddBeer() 
    {      
        BeerScore += 1;
        BeerAnimationCount();
        BeerUI.SetText(BeerScore.ToString());
    }

    private void BeerAnimationCount() 
    {
        if(BeerScore % BeerCountToPlayAnimation==0) 
        {
            BeerUIanimation.Play("BeerUiAnimation");
        }                          
    }
}
