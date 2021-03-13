using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//バトル管理
//PlayerとEnamyを取得
//攻撃する

public class BattleManager : MonoBehaviour
{
    //player取得
    public Unitmanager player;
    //enamy取得
    public Unitmanager enamy;

    void Start()
    {
        player.Attack(enamy);
        enamy.Attack(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

