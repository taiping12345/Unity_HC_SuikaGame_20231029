using Fungus;
using k;
using UnityEngine;

namespace Kylin


{
    /// <summary>
    /// 生成系統:隨機生成第一顆與下一顆物件
    /// </summary>

    public class SpawnSystem : MonoBehaviour
    {
        /*public GameObject prefabSlimes1;
        public GameObject prefabSlimes2;
        public GameObject prefabSlimes3;
        public GameObject prefabSlimes4;
        */
        /// <summary>
        /// 練習陣列與隨機
        /// </summary>
        /* private void Awake()
        {
            print(prefabSlimes[4]);
            
            prefabSlimes[7] = prefabSlimes4;

            print($"<color=#69f>陣列數量:{prefabSlimes.Length}</Color>");

            int r = Random.Range(1, 5);

            int random = Random.Range(0, prefabSlimes.Length);
            print(random);

        }
       */
        [Header("所有史萊姆預製物")]
        public GameObject[] prefabSlimes;
        public GameObject currentSlime;
        public GameObject nextSlime;
        [Header("放生成物位置")]
        public Transform spawnPoint;
        [Header("下一個物件的位置")]
        public Transform nextPoint;
        [Header("放下按鍵")]
        public KeyCode releaseSlimeKey = KeyCode.Space;
        [Header("延遲將使萊姆移到手上的時間"), Range(0, 2)]
        public float delayChangeCurrentSlime = 0.5f;
        

        public bool canReleaseSlime = true;

        private void Update()
        {
            releaseSlime();
        }
        private void Awake()
        {
            currentSlime = RandomSlime();
            nextSlime = RandomSlime();

            currentSlime = Instantiate(currentSlime, spawnPoint.position, Quaternion.identity, spawnPoint);

            nextSlime = Instantiate(nextSlime, nextPoint.position, Quaternion.identity, nextPoint);


        }

        private void releaseSlime()
        {
            bool slimeKey = Input.GetKeyUp(releaseSlimeKey);
            print($"<color=#f89>玩家沒有按下按鍵:{slimeKey}<color>");

            if (slimeKey && canReleaseSlime)
            {
                currentSlime.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                
                currentSlime.GetComponent<Rigidbody2D>().gravityScale = 1;
                
                currentSlime.GetComponent<Collider2D>().enabled = true;

                canReleaseSlime = false;
                currentSlime.transform.SetParent(null);
                SwitchCurrentAndNext();
            }
        }
        private GameObject RandomSlime()
        {
            int random = Random.Range(0, scoreManager.instance.maxSlimeIndex);
            return prefabSlimes[random];
        }
        private void SwitchCurrentAndNext()
        {
            currentSlime = nextSlime;
            nextSlime = RandomSlime();

            Invoke("DelayChangeCurrentSlime", delayChangeCurrentSlime);
        }
        private void DelayChangeCurrentSlime()
        {
            currentSlime.transform.SetParent(spawnPoint);
            currentSlime.transform.localPosition = Vector3.zero;

            nextSlime = Instantiate(nextSlime, nextPoint.position, Quaternion.identity, nextPoint);

            canReleaseSlime = true;
        }
    }



}
