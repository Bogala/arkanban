// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ARKanban
{
    [Register ("GameViewController")]
    partial class GameViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        ARKit.ARSCNView SceneView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SceneView != null) {
                SceneView.Dispose ();
                SceneView = null;
            }
        }
    }
}