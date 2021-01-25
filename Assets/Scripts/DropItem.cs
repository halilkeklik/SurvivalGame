using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public bool drops;
    public GameObject dropItem;
    public Transform dropPoint;
    private int health;
    // Update is called once per frame
    void Update()
    {
        DropCheck();
        health = GetComponent<Health>().health;
    }

    private void DropCheck()
    {
        if (drops)
        {
            if (health <= 0)
            {
                Instantiate(dropItem, dropPoint.position, dropPoint.rotation);
            }
        }
    }
}
