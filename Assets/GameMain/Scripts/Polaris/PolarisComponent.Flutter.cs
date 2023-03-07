using System;
using FlutterUnityIntegration;
using UnityEngine;
using UnityGameFramework.Runtime;

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
            _unityMessageManager.SendMessageToFlutter("app.quit");
            Debug.Log("Send Unity message app.quit");
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

        /// <summary>
        /// 不要调用这个方法，会导致app退出
        /// </summary>
        void QuitGame()
        {
            UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Quit);
            Debug.Log("Received message from flutter: QuitGame");
        }

        /// <summary>
        /// 重新加载游戏
        /// </summary>
        void ReloadGame()
        {
            UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Restart);
            Debug.Log("Received message from flutter: ReloadGame");
        }

        /// <summary>
        /// 暂停游戏，验证有效
        /// </summary>
        void PauseGame()
        {
            Debug.Log("Received message from flutter: PauseGame");
            Time.timeScale = 0;
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