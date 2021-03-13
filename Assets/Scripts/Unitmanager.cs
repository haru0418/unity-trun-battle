using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//キャラ管理
//ステータス、攻撃関数、ダメージ関数

public class Unitmanager : MonoBehaviour
{
    //ステータス
    public int hp;
    public int at;


    //攻撃関数
    public void Attack(Unitmanager target) //targetはbattlemanager.csの（player）（enamy）を持ってきている
    {
        target.Damage(at); //atは設定したatを取得
    }
    

    //ダメージ関数
    void Damage(int damage) //上のatの引数に入った値をもらっている
    {
        hp -= damage;
        Debug.Log(name+"は"+damage+"ダメージ");
        if (hp <= 0)
        {
            hp = 0;
            Debug.Log(name + "戦闘不能");
        }
    }
}
