using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


    [RequireComponent(typeof(AudioSource))]
    public class MainMenu : MonoBehaviour
    {
        [Header("Buttons")]
        [SerializeField] Button startButton;
        [SerializeField] Button exitButton;

        [Header("Button Sound")]
        [SerializeField] AudioClip buttonSound;
        AudioSource menuAudio;

        UnityAction _menuFunctionList;

        [Header("Custom Interactions ")]
        [SerializeField] string firstScene;
        private void Awake()
        {
            menuAudio = GetComponent<AudioSource>();
        }
        void Start()
        {
            SetMenuListeners();
        }
       
        void SetMenuListeners() 
        {
            AssignButton(startButton,StartGame);
            AssignButton(exitButton,ExitGame);
        }
        
        void AssignButton(Button _button,UnityAction _call) 
        {
            _button.onClick.AddListener(_call);
            _button.onClick.AddListener(PlayButtonSound);
        }

        void PlayButtonSound() 
        {
            menuAudio.PlayOneShot(buttonSound);
        }
       
        /// <summary>
        /// If you created an event, after finishing the assignment you have to clear the menu function
        /// </summary>
        void ClearMenuFunctionList() 
        {
            _menuFunctionList = null;
        }

        #region Custom Button Interactions
        void StartGame()
        {
            //SceneManager.LoadScene(firstScene);
            Debug.Log("Starting The Game");
        }
        void ExitGame()
        {
            //Application.Quit();
            Debug.Log("Exiting The Game");
        }
        #endregion


    }

