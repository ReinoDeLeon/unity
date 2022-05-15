using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    #region Singleton
    public static playerManager  playerMan;

    void Awake()
    {
        playerMan = this;
    }


    #endregion

    public GameObject player;

}
