using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerHp = 10;

    public void Damage()
    {
        //player�̗̑͂�1���炷
        playerHp = playerHp - 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //�����̗͂�0�ȉ��ɂȂ�����
        if (playerHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }

    }
}
