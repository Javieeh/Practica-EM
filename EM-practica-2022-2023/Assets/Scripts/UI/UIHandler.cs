using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIHandler : MonoBehaviour
    {
        public GameObject canvasMenu;
        public Button hostButton;
        public Button clientButton;
        public Button exitButton;

        private void Start()
        {
            hostButton.onClick.AddListener(OnHostButtonClicked);
            clientButton.onClick.AddListener(OnClientButtonClicked);
            exitButton.onClick.AddListener(OnExitButtonClicked);
        }

        private void OnHostButtonClicked()
        {
            NetworkManager.Singleton.StartHost();
            canvasMenu.SetActive(false);
        }

        private void OnClientButtonClicked()
        {
            NetworkManager.Singleton.StartClient();
            canvasMenu.SetActive(false);
        }

        private void OnExitButtonClicked()
        {
            Application.Quit();
        }
    }
}