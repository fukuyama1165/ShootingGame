using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int playerHp = 10;

    public void Damage()
    {
        //player‚Ì‘Ì—Í‚ð1Œ¸‚ç‚·
        playerHp = playerHp - 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //‚à‚µ‘Ì—Í‚ª0ˆÈ‰º‚É‚È‚Á‚½‚ç
        if (playerHp <= 0)
        {
            //Ž©•ª‚ÅÁ‚¦‚é
            Destroy(this.gameObject);
        }

    }
}
