using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool canPlayerMove = true;

    public static bool isOpenInventory = false;

    public static bool isPause = false;

    // Update is called once per frame
    void Update()
    {
        if (isOpenInventory || isPause)
        {

            canPlayerMove = false;
        }
        else
        {

            canPlayerMove = true;

        }
    }

  
}
