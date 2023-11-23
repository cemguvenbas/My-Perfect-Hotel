using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;


public class MenuItems : MonoBehaviour
{
    [MenuItem("Tools/Organize Hierarchy")]
    static void OrganizeHierarchy()
    {
        new GameObject("--- ENVIRONEMENT ---");
        new GameObject(" ");

        new GameObject("--- GAMEPLAY ---");
        new GameObject(" ");

        new GameObject("--- UI ---");
        new GameObject(" ");

        new GameObject("--- MANAGERS ---");
    }
}

#endif