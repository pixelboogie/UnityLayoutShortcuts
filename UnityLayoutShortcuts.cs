 using UnityEngine;
 using UnityEditor;
 
 public class LayoutShortCuts :  MonoBehaviour {


//   [MenuItem("MyMenu/Do Something")]
//    static void DoSomething()
  //  {
    //    Debug.Log("Doing Something...");
   // }
     
 
 
     //[MenuItem("Window/LayoutShortcuts/1 %1", false, 999)]
     [MenuItem("Window/LayoutShortcuts/1 &1", false, 999)]
     static void Layout1() {
        // EditorApplication.ExecuteMenuItem("Window/Layouts/BLACKISH Default");
         EditorApplication.ExecuteMenuItem("Window/Layouts/Working");
     }
 

     [MenuItem("Window/LayoutShortcuts/2 &2", false, 999)]
     static void Layout2() {
         EditorApplication.ExecuteMenuItem("Window/Layouts/MyEditing");
     }

     [MenuItem("Window/LayoutShortcuts/3 &3", false, 999)]
     static void Layout3() {
         EditorApplication.ExecuteMenuItem("Window/Layouts/Scene");
     }
 }