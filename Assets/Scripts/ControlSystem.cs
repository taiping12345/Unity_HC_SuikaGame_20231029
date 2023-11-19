using UnityEngine;      //引用unity函式庫
namespace Kylin
{
    /// <summary>
    /// 角色動作系統
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        /*
        public int lv = 1;
        public float cd = 3.5f;
        public string skillName = "永恆詛咒";
        public bool isDead = false;

        private void Awake()
        {
        

        print("6666");
        print("哈囉，世界");
    }
    private void Start()
    {
        print("我們開始賺分數吧")

        }
    private void Update()
    {
        print("使自己的分數是最高的")
    
        }
    */
        [Header("移動速度"),Range (0,50) ]
        public float moveSpeed = 2.5F;
        [Header("右邊界"),Tooltip ("角色移動右邊界")]
        public float limitLeft = -4.5f;
        [Header("左邊界"),Tooltip ("角色移動左邊界")]
        public float limitRight = 4.5f;
    }
}


