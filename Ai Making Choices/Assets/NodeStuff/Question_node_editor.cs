//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEditor;
//using UnityEngine;
//using UnityEngine.UIElements;
//using XNodeEditor;
//using static XNodeEditor.NodeEditor;

////[CustomNodeEditor(typeof(Question_node))]

//public class Question_node_editor : NodeEditor
//{
//    private Question_node question;
//   // public Slider slider;(Rect position, SerializedProperty property, float leftValue, float rightValue)
//    public override void OnBodyGUI()
//    {
//        if (question == null) question = target as Question_node;

//        serializedObject.Update();

//        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("entry"));
//        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("ansNum"));
//        if (question.ansNum > 4)
//        {
//            question.ansNum = 4;
//        }
//        else if (question.ansNum < 2)
//        {
//            question.ansNum = 2;
//        }
//        //question.ansNum = (int)EditorGUI.Slider(new Rect(5, 50, 150, 20), question.ansNum, 2, 4);

//        if (question.ansNum >= 2)
//        {
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("Q1"));
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("A1"));
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("Q2"));
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("A2"));
//        }
//        if (question.ansNum >= 3)
//        {
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("Q3"));
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("A3"));
//        }
//        if (question.ansNum == 4)
//        {
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("Q4"));
//            NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("A4"));
//        }
//        if (question.ansNum > 4 || question.ansNum < 2)
//        {
//            Debug.Log("Error: Incorrect number of answers for question node");
//        }
//        // Apply property modifications
//        serializedObject.ApplyModifiedProperties();
//    }
//}
