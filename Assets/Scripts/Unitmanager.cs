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
    public void Attack(Unitmanager target)
    {
        target.Damage(at);
    }


    //ダメージ関数
    void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(name+"は"+damage+"ダメージ");
    }
}
