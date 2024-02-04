using UnityEngine;
using UnityEngine.SceneManagement;
namespace k
{
    public class SceneControl : MonoBehaviour
    {
        public void LoadScene(string scene)
        {
            print("載入場景");
            SceneManager.LoadScene(scene);
        }
        public void Quit()
        {
            print("離開遊戲");
            Application.Quit();
        }

    }

}
