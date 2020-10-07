using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CentralDataViewer))]
public class CentralDataViewerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CentralDataViewer mTarget = (CentralDataViewer)target;
        EditorGUILayout.LabelField("Audio", mTarget.AudioVol.ToString());
        EditorGUILayout.LabelField("Player", mTarget.Player);
        EditorGUILayout.LabelField("Enemy", mTarget.Enemy);
    }
}
