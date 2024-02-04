using k;
using System.Runtime.CompilerServices;
using UnityEngine;
namespace K
{
    [DefaultExecutionOrder(0)]
    public class MergeSystem : MonoBehaviour
    {
        [Header("�Ҧ��v�ܩi�w�s��")]
        public GameObject[] prefabSlimes;
        [SerializeField, Header("�X������")]
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

                print("<color=#99f>�X��</color>");
                
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

