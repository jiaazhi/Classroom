using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public static class GameLogic
{
    public static void Inti()
    {
        Debug.Log("GameLogic.Init");

        CreateSprite(GameAssets.i.s_ShootFlash);
    }

    private static void CreateSprite(Sprite sprite)
    {
        UtilsClass.CreateWorldSprite("Sprite", sprite, Vector3.zero, new Vector3(20, 20), 0, Color.white);
    }
}