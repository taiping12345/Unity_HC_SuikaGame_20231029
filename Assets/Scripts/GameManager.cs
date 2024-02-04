﻿using UnityEngine;
using System.Collections;
using Kylin;

namespace K
{

    public class GameMANAGER : MonoBehaviour
    {
        [SerializeField, Header("結束畫面群組")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("原住民")]
        private ControlSystem ControlSystem;
        [SerializeField, Header("生成系統")]
        private SpawnSystem spawnSystem;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            print($"<color=#f69>碰到的物件 : {collision.name}</color>");
            StartCoroutine(FadeIn());
        }
        private IEnumerator FadeIn()
        {
            ControlSystem.enabled = false;
            spawnSystem.enabled = false;
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.05f);

            }
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;

        }
        /* private void Awake()
         {
             StartCoroutine(test());

             for (int i = 0; i < 1000; i++)
             {
                 print("測試");
             }
         }

         private IEnumerator test()
         {
             for (int i = 0; i < 10; i++)
             {
                 groupFinal.alpha += 0.1f;
                 yield return new WaitForSeconds(0.05f);
             }*/

    }
}