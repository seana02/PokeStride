using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.UI;
using Stride.UI.Controls;
using Stride.Core.Serialization;

namespace PokeStride
{
    public class PlayScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        
        public UrlReference<Scene> ChildSceneUrl { get; set; }

        public override void Start()
        {
            // Initialization of the script.
            UIPage page = Entity.Get<UIComponent>().Page;
            var rootElement = page.RootElement;
            var playButton = rootElement.FindVisualChildOfType<Button>("playButton");
            playButton.Click += delegate
            {
                rootElement.Visibility = Visibility.Hidden;


                var parentScene = Entity.Scene;

                var childScene = Content.Load(ChildSceneUrl);

                parentScene.Children.Add(childScene);
            };
        }

        public override void Update()
        {
            // Do stuff every new frame
        }
    }
}
