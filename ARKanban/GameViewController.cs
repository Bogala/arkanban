using System;
using System.Collections.Generic;
using ARKit;
using CoreGraphics;
using SceneKit;
using UIKit;

namespace ARKanban
{
    public partial class GameViewController : UIViewController
    {
        protected GameViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // create a new scene
            var scene = SCNScene.FromFile("art.scnassets/ARKanbanScene.scn");

  

            // set the scene to the view
            SceneView.Scene = scene;

            // show statistics such as fps and timing information
            SceneView.ShowsStatistics = true;

            // configure the view
            SceneView.BackgroundColor = UIColor.Black;

            // add a tap gesture recognize
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var configuration = new ARWorldTrackingConfiguration
            {
                PlaneDetection = ARPlaneDetection.Horizontal,
                LightEstimationEnabled = true
            };

            SceneView.Session.Run(configuration, ARSessionRunOptions.ResetTracking);
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.AllButUpsideDown;
        }
    }
}
