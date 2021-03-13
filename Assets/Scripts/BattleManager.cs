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

    }

    public void OnClickAttackButton()
    {
        player.Attack(enamy); //unitmanagerのattackの引数のtargetに行く
        EnamyAttack();
    }

    public void EnamyAttack()
    {
        enamy.Attack(player); //unitmanagerのattackの引数のtargetに行く

    }
}

