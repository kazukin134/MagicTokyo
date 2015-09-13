﻿using UnityEngine;
using System.Collections;

public class MaterialChanger : MonoBehaviour
{

    [SerializeField]
    Material material_1p_ = null;

    [SerializeField]
    Material material_2p_ = null;

    // Use this for initialization
    void Start()
    {
        if (MyNetworkLobbyManager.s_singleton.Is1P)
        {
            GetComponent<MeshRenderer>().material = material_1p_;
        }
        else
        {
            GetComponent<MeshRenderer>().material = material_2p_;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
