using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GamePlayer : MonoBehaviour
{
    //����,����
    public string PlayerName; // ���� - string
    public int Score; // ���� - int (�Ҽ��� x)
    public int Hp; // 
    public float GameTimer; // ���� - float (�Ҽ��� o)
    public bool IsPlaying;  // �³� Ʋ���� ture false

    private void Start()
    {
    
    }

    private void Update()
    {
        if( ! IsPlaying)
        {
            Debug.Log("������ �������ϴ�.");
            return;

        }


        GameTimer = GameTimer - Time.deltaTime;

        if (GameTimer < 0)
        {
            IsPlaying = false;
        }
    }



    private void OnTriggerEnter(Collider other)
    {

        bool isEnemy = other.gameObject.tag == "Enemy";
        bool isItem = other.gameObject.tag == "Item";

        if (isEnemy)
        {
            Debug.Log("Enemy Check");
            Hp = Hp - 1;


            //if hp <= 0 - IsPlaying = false
            if (Hp <= 0)
            {
                IsPlaying = false;
            }
        }


        if (isItem)
        {
            Debug.Log("Item Check");
            Score = Score + 1;


        }

        Destroy(other.gameObject);


        //Debug.Log ("�ȳ��ϼ���.")




    }

}
