using K;
using System;
using UnityEngine;
namespace k

{
    public class SlimeSystem : MonoBehaviour
    {
        [Header("�v�ܩi�s��"), Range(0, 8)]
        public int index;
        
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print($"<color=#f69>�I�쪺����){collision.gameObject.name}</Color>");

            if(collision.gameObject.name == gameObject.name)
            {

                print($"<color=#69f>�n�ͥX���v�ܩi�s��{index + 1 }</color>");

                MergeSystem.instance.Merge(index + 1);

                Destroy(gameObject);


            }

        }
    }
}


