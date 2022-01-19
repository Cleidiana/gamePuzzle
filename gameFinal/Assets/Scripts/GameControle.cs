using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControle : MonoBehaviour {
    public GameObject inventory;
    public static GameControle instance;

    void Awake()
    {
        instance = this;
    }

    public void AtiveInventory()
    {
        print("ativou");
    }
    public void ExitInventory()
    {

    }
}
