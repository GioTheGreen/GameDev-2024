//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using XNodeEditor;

////[CustomNodeEditor(typeof(Show_node))]
//public class Show_node_editor : NodeEditor
//{
//    private Show_node show;

//    public override void OnBodyGUI()
//    {
//        if (show == null) show = target as Show_node;

//        serializedObject.Update();

//        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("entry"));
//        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("exit"));
//        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("mode"));

//        switch (show.mode)
//        {
//            case Show_node.Emode.one:
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("chacactor"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("exprestion"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("map"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("Dialog"));
//                break;
//            case Show_node.Emode.two:
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("chacactor"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("exprestion"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("chacactor2"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("exprestion2"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("first"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("map"));
//                NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("Dialog"));
//                break;
//            default:
//                break;
//        }
//        // Apply property modifications
//        serializedObject.ApplyModifiedProperties();
//    }
//}
