using UnityEngine;
namespace K
{
    [DefaultExecutionOrder(0)]
    public class MergeSystem : MonoBehaviour
    {
        [Header("�Ҧ��v�ܩi�w�s��")]
        public GameObject[] prefabSlimes;


        public static MergeSystem instance;
        private void Awake()
        {
            instance = this;

        }
        public void Merge(int _index)
        {
            print("<color=#99f>�X��</color>");
            Instantiate(prefabSlimes[_index], Vector3.zero, Quaternion.identity);

        }
    }
}
