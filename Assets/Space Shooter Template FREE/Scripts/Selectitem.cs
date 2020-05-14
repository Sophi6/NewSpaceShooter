using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selectitem : MonoBehaviour
{
    public GameObject[] item;

    private int itemCount;



    public void LeftSelect()
    {
        if (itemCount > 0)
        {
            item[itemCount].SetActive(true);
            itemCount--;
            item[itemCount].SetActive(true);


        }
    }
    public void RightSelect()
    {
        if (itemCount < item.Length)
        {
            item[itemCount].SetActive(true);
            itemCount++;
            item[itemCount].SetActive(true);


        }

    }
}
