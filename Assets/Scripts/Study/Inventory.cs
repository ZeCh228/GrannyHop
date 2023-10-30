using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] InventoryItem Item;
    int x = 10;
    private void Update()
    {
        switch (Item.type) 
        {
            case ItemType.apple:
                Debug.Log("apple");
                break;

            case ItemType.gun:
                Debug.Log("gun");
                return;

            case ItemType.bear:
                Debug.Log("bear");
                break;
            default:
                Debug.Log("default");
                break;
        }
        Debug.Log("below Update");        
        
        switch (x)
        {
            case 10:
                break;
         
            default:
                break;
        }
    }

}
