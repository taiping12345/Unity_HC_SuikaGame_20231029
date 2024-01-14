using TMPro;
using UnityEngine;
namespace k
{
[DefaultExecutionOrder(0)]
public class scoreManager : MonoBehaviour
{
        [Header("分數")]
        public TextMeshProUGUI textScore;
        public int maxSlimeIndex = 2;

        public int[] slimeScores = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        private int totalScore;

        public static scoreManager instance;

        private void Awake()
        {
            instance = this;
        }
        public void AddScore(int _index)
         {

            int score = slimeScores[_index];

            totalScore += score;

            textScore.text = totalScore.ToString();

            ChangMaxSlimeIndex();

         }
        private void ChangMaxSlimeIndex()
        {
            if (totalScore >= 500) maxSlimeIndex = 6;

            else if (totalScore >= 100) maxSlimeIndex = 4;

            print($"<color=#f99>最大史萊姆編號:{maxSlimeIndex}</color>");
        }
}
    
}

