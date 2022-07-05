using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerHp = 10;

    public void Damage()
    {
        //playerの体力を1減らす
        playerHp = playerHp - 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //もし体力が0以下になったら
        if (playerHp <= 0)
        {
            //自分で消える
            Destroy(this.gameObject);
        }

    }
}
