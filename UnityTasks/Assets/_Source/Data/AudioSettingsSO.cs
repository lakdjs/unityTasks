using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(menuName = "SO/New Audio Settings", fileName = "AudioSettings")]

    public class AudioSettingsSO : ScriptableObject
    {
        [Header("Character Properties")] 
        [SerializeField] private float speed;
        
        [Header("Bullet Properties")]
        [SerializeField] private float bulletSpeed;


        [Space(30)]
        [SerializeField] private AudioTypes audioTypes;
        [SerializeField] private List<AudioData> audioDataDangerous;
        [SerializeField] private List<AudioData> audioDataFriendly;
        [SerializeField] private List<AudioData> audioDataNeutral;

        [SerializeField] private string message;
        
    }

    
    [Serializable]
    public class AudioData
    {
        [field: SerializeField] public AudioClip AudioClip { get; private set; }
        [field: SerializeField] public float Volume { get; private set; }
    }

    [CustomEditor(typeof(AudioSettingsSO))]
    [CanEditMultipleObjects]
    public class AudioEditor : Editor
    {
        private SerializedProperty speed;
        private SerializedProperty bulletSpeed;
        private SerializedProperty message;
        private SerializedProperty audioTypes;
        private SerializedProperty audioList;
        private bool messageGuiOn;
        private bool listGuiOn;
        private bool clearOn;
        private int uid;
        private void OnEnable()
        {
            messageGuiOn = false;
            listGuiOn = false;
            audioTypes = serializedObject.FindProperty("audioTypes");
            speed = serializedObject.FindProperty("speed");
            bulletSpeed = serializedObject.FindProperty("bulletSpeed");
            message = serializedObject.FindProperty("message");
#if unity_editor
            if (uid == "")
            {
                uid = guid.generate().tostring();
                unityeditor.editorutility.setdirty(this);
            }
#endif
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(speed);
            EditorGUILayout.PropertyField(audioTypes);
            if (audioTypes.enumValueFlag == 0)
            {
                audioList = serializedObject.FindProperty("audioDataDangerous");
            }
            if (audioTypes.enumValueFlag == 1)
            {
                audioList = serializedObject.FindProperty("audioDataFriendly");
            }
            if (audioTypes.enumValueFlag == 2)
            {
                audioList = serializedObject.FindProperty("audioDataNeutral");
            }
            //EditorGUILayout.PropertyField(audioList);
            EditorGUILayout.Slider(bulletSpeed, 0, 10);

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Drop Data"))
            {
                listGuiOn = true;
                Debug.Log("dropped data");
            }
            if (GUILayout.Button("Get Data"))
            {
                messageGuiOn = true;
                Debug.Log("got data");
            }
            if (GUILayout.Button("Clear Data"))
            {
                messageGuiOn = false;
                listGuiOn = false;  
                Debug.Log("cleared data");
            }
            else
            {
                clearOn = false;
                Debug.Log("cleared data");
            }
            EditorGUILayout.EndHorizontal();
            if (messageGuiOn)
            {
                EditorGUILayout.PropertyField(message);
            }
            if (listGuiOn)
            {
                EditorGUILayout.PropertyField(audioList);
            }

            if (clearOn == false)
            {
                
            }
            serializedObject.ApplyModifiedProperties();
            //base.OnInspectorGUI();
        }
        
    }
}
