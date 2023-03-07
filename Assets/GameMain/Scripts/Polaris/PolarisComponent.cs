using System.Collections;
using System.Collections.Generic;
using FlutterUnityIntegration;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace StarForce
{
    public partial class PolarisComponent : MonoBehaviour
    {
        void OnGUI()
        {
            GUILayout.BeginArea(new Rect(300, 100, 300, 300));
            MessageButtons();

            GUILayout.EndArea();
        }
    
        void MessageButtons()
        {
            if (GUILayout.Button("Send", GUILayout.Height(64)))
                sendMessageToFlutter();
        }
        
        void Start()
        {
            _unityMessageManager = GetComponent<UnityMessageManager>();
            if (_unityMessageManager is null)
                Log.Debug("cannot get unity message manager, plz check");
        }

    }
}

