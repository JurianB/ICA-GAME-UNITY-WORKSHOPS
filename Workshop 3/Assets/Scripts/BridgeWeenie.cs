using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeWeenie : MonoBehaviour
{
    [SerializeField]
    private string[] _itemsNeededAsString;

    [SerializeField]
    private GameObject bridge;

    private List<Item> _itemsNeeded = new List<Item>();

    private Inventory _inventory;

    void Start()
    {
        _inventory = GameObject.FindObjectOfType<Inventory>();

        for (int i = 0; i < _itemsNeededAsString.Length; i++)
        {
            _itemsNeeded.Add(new Item(_itemsNeededAsString[i]));
        }
    }


    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (CheckHasAllItemsNeeded())
            {
                bridge.SetActive(true);
                
                gameObject.GetComponent<Renderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }

    bool CheckHasAllItemsNeeded()
    {
        return _inventory.CheckHasItems(_itemsNeeded);
    }
}
