using UnityEngine;
using UnityEngine.SceneManagement;
namespace k
{
    public class SceneControl : MonoBehaviour
    {
        private string scene;
        public void LoadScene(string scene)
        {
            this.scene = scene;
            Invoke("DelavLoadScene", 1.2f);
        }
        private void DelavLoadScene()
        {
            SceneManager.LoadScene(scene);
        }    
        public void Quit()
        {
            Invoke("DelayQuit", 1.2f);
           
        }

        private void DelayQuit()
        {
            Application.Quit();
        }
    }

}
