using System;
using FlutterUnityIntegration;
using UnityEngine;

namespace StarForce
{

    public enum FlutterMessage : byte
    {
        Quit,
    }
    
    
    public partial class PolarisComponent
    {
        private UnityMessageManager _unityMessageManager;

        private bool playing = false;

        private void sendMessageToFlutter() {
            Debug.Log("GameFramework QUIT");
            // GameEntry.Shutdown(ShutdownType.Quit);
            _unityMessageManager.SendMessageToFlutter("app.quit");
            Debug.Log("Send Unity message app.quit");
            // yield return null;
        }
    
        /// <summary>
        /// Receive flutter message
        /// </summary>
        /// <param name="speed"></param>
        void SetRotationSpeed(string speed) {
            Debug.Log("Received message from flutter speed: " +speed);
            float s = float.Parse(speed);
            if (s >= 0) {
                Debug.Log("setting speed to "+speed);
            }
        }

        void QuitGame()
        {
            Debug.Log("Received message from flutter: QuitGame");
        }

        void ReloadGame()
        {
            Debug.Log("Received message from flutter: ReloadGame");
        }

        /// <summary>
        /// 暂停游戏，验证有效
        /// </summary>
        void PauseGame()
        {
            Debug.Log("Received message from flutter: PauseGame");
            Time.timeScale = 0;
            // Application.isPlaying = false;
        }

        /// <summary>
        /// 恢复游戏，验证有效
        /// </summary>
        void ResumeGame()
        {
            Debug.Log("Received message from flutter: ResumeGame");
            Time.timeScale = 1;
        }
    }
}