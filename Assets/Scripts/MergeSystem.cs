using k;
using System.Runtime.CompilerServices;
using UnityEngine;
namespace K
{
    [DefaultExecutionOrder(0)]
    public class MergeSystem : MonoBehaviour
    {
        [Header("所有史萊姆預製物")]
        public GameObject[] prefabSlimes;
        [SerializeField, Header("合成音效")]
        private AudioClip soundMerge;


        public static MergeSystem instance;
        private bool canMerge = true;

        private void Awake()
        {
            instance = this;

        }
        public void Merge(int _index,Vector2 _point)
        {
            if (canMerge)
            {
                canMerge = false;
                GameObject tempslimes = Instantiate(prefabSlimes[_index],_point, Quaternion.identity);

                print("<color=#99f>合成</color>");
                
                tempslimes.GetComponent<Rigidbody2D>().gravityScale = 1;
                
                tempslimes.GetComponent<Collider2D>().enabled = true;
                
                tempslimes.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Invoke("CanMerge", 0.001f);

                scoreManager.instance.AddScore(_index);

                SoundManager.instance.PlaySound(soundMerge);
            }
        
        }

        private void CanMerge()
        {
            canMerge = true;
        }
    }
}

