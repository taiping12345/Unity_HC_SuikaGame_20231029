using UnityEngine;
namespace K
{
    [DefaultExecutionOrder(0)]
    public class MergeSystem : MonoBehaviour
    {
        [Header("所有史萊姆預製物")]
        public GameObject[] prefabSlimes;


        public static MergeSystem instance;
        private bool canMerge = true;

        private void Awake()
        {
            instance = this;

        }
        public void Merge(int _index)
        {
            if (canMerge)
            {
                canMerge = false;
                print("<color=#99f>合成</color>");
                Instantiate(prefabSlimes[_index], Vector3.zero, Quaternion.identity);

            }
            
        }
    }
}

