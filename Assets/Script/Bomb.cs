using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //表示させるパーティクルを設定
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キーボードのBキーが押されたら
        if(Input.GetKeyDown(KeyCode.B))
        {
            //タグが同じオブジェクトを全て取得する
            GameObject[] enemyBulletObjects = GameObject.FindGameObjectsWithTag("EnemyBullet");

            //上で取得したすべてのオブジェクトを消滅させる
            for(int i=0;i<enemyBulletObjects.Length;i++)
            {
                Destroy(enemyBulletObjects[i].gameObject);
            }

            Instantiate(particle, Vector3.zero, Quaternion.identity);

        }
    }
}
