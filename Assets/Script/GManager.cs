using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    //�G�̐��𐔂���p�̕ϐ�
    private GameObject[] enemy;

    private GameObject player;

    //�p�l����o�^����
    public GameObject panel;

    public GameObject buttan1;
    public GameObject buttan2;

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        buttan1.SetActive(false);
        buttan2.SetActive(false);
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[���ɑ��݂��Ă���Enemy�^�O�������Ă���I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if(enemy.Length ==0)
        {
            panel.SetActive(true);
            buttan1.SetActive(true);
            buttan2.SetActive(true);
        }

        player = GameObject.FindGameObjectWithTag("Player");

        if(player==null)
        {
            ChangeScene("GameOver");
        }

    }
   

}
