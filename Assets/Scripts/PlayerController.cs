﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerController : NetworkBehaviour
{
  public static int pId = -1;

  private void Start()
  {
    if (isServer)
    {
      pId = 0;
    }
    else
    {
      pId = 1;
    }
    Camera.main.GetComponent<GridDisplay>().Init();
  }

  private void Update()
  {
    if (isLocalPlayer)
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        Application.Quit();
    }
  }
}