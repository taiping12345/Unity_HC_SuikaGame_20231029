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
        
        private void Awake()
        {
            int random = Random.Range(0, prefabSlimes.Length);
            currentSlime = prefabSlimes[random];

            int randomNext = Random.Range(0,prefabSlimes.Length);
            nextSlime = prefabSlimes[randomNext];


        }
    }
    
    

}
