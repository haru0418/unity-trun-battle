using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if ( enamy.hp > 0 )
        {
            EnamyAttack();
        }
        else
        {
            BattleEnd();
        }
    }

    void EnamyAttack()
    {
        enamy.Attack(player);//unitmanagerのattackの引数のtargetに行く
        if (player.hp == 0)
        {
            BattleEnd();
        }
    }

    void BattleEnd()
    {
        Debug.Log("戦闘終了");
        string currrntScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currrntScene);
    }
}

