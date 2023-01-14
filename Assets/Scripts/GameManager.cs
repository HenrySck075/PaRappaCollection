using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int curRank;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


}
