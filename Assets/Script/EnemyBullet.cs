using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //弾のスピード
    public float speed = 1;

    //自然消滅までのタイマー
    public float time = 2;

    //進行方向
    protected Vector3 forward = new Vector3(0, 0, 1);

    //打ち出すときの角度
    protected Quaternion forwardAxis = Quaternion.identity;

    //Rigidbody用変数
    protected Rigidbody rb;

    //enemy用変数
    protected GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody用変数を初期化
        rb = this.GetComponent<Rigidbody>();
        if(enemy!=null)
        {
            forward = enemy.transform.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //移動量を進行方向にスピード分だけ加える
        rb.velocity = forwardAxis * forward * speed;

        //空中に浮かないようにする
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        //制限時間が来たら自然消滅する
        time -= Time.deltaTime;

        if(time<=0)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player" || other.gameObject.tag=="PlayerBody")
        {
           other.GetComponent<Player>().Damage();

            Destroy(this.gameObject);
        }
    }

    //弾を打ち出したキャラクターの情報を渡す関数
    public void SetCharacterObject(GameObject character)
    {
        //弾をを打ち出したキャラクターの情報を受け取る
        this.enemy = character;
    }

    //打ち出す角度を決定する為の関数
    public void SetForwardAxis(Quaternion axis)
    {
        //指定された角度を受け取る
        this.forwardAxis = axis;
    }

}
