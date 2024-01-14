using K;
using System;
using UnityEngine;
namespace k

{
    public class SlimeSystem : MonoBehaviour
    {
        [Header("史萊姆編號"), Range(0, 8)]
        public int index;
        
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print($"<color=#f69>碰到的物件){collision.gameObject.name}</Color>");

            if(collision.gameObject.name == gameObject.name)
            {

                print($"<color=#69f>要生出的史萊姆編號{index + 1 }</color>");

                MergeSystem.instance.Merge(index + 1);

                Destroy(gameObject);


            }

        }
    }
}


