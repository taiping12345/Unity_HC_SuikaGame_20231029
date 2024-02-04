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
        [Header("所有史萊姆的分數")]
        public int[] slimeScores = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        [SerializeField, Header("最佳分數")]
        private TextMeshProUGUI textHighScore;

        private int totalScore;

        public static scoreManager instance;

        private void Awake()
        {
            instance = this;
            textHighScore.text = PlayerPrefs.GetInt("最高分數").ToString();
        }
        public void AddScore(int _index)
         {

            int score = slimeScores[_index];

            totalScore += score;

            textScore.text = totalScore.ToString();

            ChangMaxSlimeIndex();

            HighScore();

         }
        
        private void HighScore()
        {
            int highScore = PlayerPrefs.GetInt("最高分數");
            if (totalScore > highScore) PlayerPrefs.SetInt("最高分數", totalScore);
        }

        private void ChangMaxSlimeIndex()
        {
            if (totalScore >= 500) maxSlimeIndex = 6;

            else if (totalScore >= 100) maxSlimeIndex = 4;

            print($"<color=#f99>最大史萊姆編號:{maxSlimeIndex}</color>");
        }
}
    
}

