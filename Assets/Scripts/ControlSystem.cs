using UnityEditor.Tilemaps;
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
        [Header("圖片渲染元件"), SerializeField]
       
        private Animator ani;
        [Header("動畫控制元件"), SerializeField]
        private SpriteRenderer sprite;

        private string parMove = "移動畫面";
        /* private void Awake()
         {
             print(6666);
             print("hello world");
             print(moveSpeed);
             print("<Color=red>紅色文字</Color>");
         }
        */
        private void Update()
        {
            Move();
            UpdateAnimation();
            Flip();
        }

       public float inputHorizontal
        {
            get
            {
                return Input.GetAxis("Horizontal");
            }
        }
        
        /// <summary>
        /// 移動方法:偵測玩家的輸入並控制角色移動以及範圍限制
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            print($"<color=#96f>水平值:{h}</color>");
            float v = Input.GetAxis("Vertical");
            print($"<color=#96f>水平值:{v}</color>");

            //print(transform.position);

            transform.Translate(inputHorizontal * Time.deltaTime * moveSpeed, 0, 0);

            Vector3 point = transform.position;

            point.x = Mathf.Clamp(point.x, limitLeft, limitRight);


            transform.position = point;
        }
        private void UpdateAnimation()
        {
            float hAbs = Mathf.Abs(inputHorizontal);

            ani.SetFloat(parMove, hAbs);
        }
        private void Flip()
        {
            if (Mathf.Abs(inputHorizontal) < 0.1f) return;

            sprite.flipX = inputHorizontal < 0;

        }
    }
}


