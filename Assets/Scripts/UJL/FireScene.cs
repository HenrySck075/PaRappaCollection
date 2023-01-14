using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScene : MonoBehaviour
{
    public Animator good;
    private int rank = FindObjectOfType<GameManager>().curRank;

    void Start()
    {
        this.good.SetTrigger("idle");
    }

    void Update()
    {
        if ( rank == 3 )
        {
            this.good.SetTrigger("idle");
        }
        else if ( rank == 4 || rank == 5 )
        {
            this.good.SetTrigger("flash");
        }
        else if (rank == 6)
        {
            this.good.SetTrigger("dim");
        }
    }
}
