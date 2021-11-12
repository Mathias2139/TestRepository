using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class CreateMenu : MonoBehaviour
{
    [MenuItem("GameObject/ Heksespil/Minigame",false,10)]
    static void CreateCustomGameObject(MenuCommand menuCommand)
    {
        // Create a custom game object
        GameObject go = new GameObject("Custom Game Object");
        go.AddComponent<Minigame>();
        go.gameObject.name = "New Minigame";
        // Ensure it gets reparented if this was a context click (otherwise does nothing)
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        // Register the creation in the undo system

        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
    }
}
