using K;
using System;
using UnityEngine;
namespace k

{
    public class SlimeSystem : MonoBehaviour
    {
        [Header("�v�ܩi�s��"), Range(0, 8)]
        public int index;

        /*private void Awake()
        {
            Vector2 a = new Vector2(1, 1);
            Vector2 b = new Vector2(100, 100);
            print(Vector2.Lerp(a, b, 0.5f));

        }*/

        private void OnCollisionEnter2D(Collision2D collision)
        {
            print($"<color=#f69>�I�쪺����){collision.gameObject.name}</Color>");

            if(collision.gameObject.name == gameObject.name)
            {

                print($"<color=#69f>�n�ͥX���v�ܩi�s��{index + 1 }</color>");

                Vector2 pointA = transform.position;

                Vector2 ponintB = collision.transform.position;

                Vector2 result = Vector2.Lerp(pointA, ponintB, 0.5f);

                MergeSystem.instance.Merge(index + 1);

                Destroy(gameObject);


            }

        }
    }
}


