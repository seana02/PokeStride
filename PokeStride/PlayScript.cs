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

namespace PokeStride
{
    public class PlayScript : SyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            // Initialization of the script.
            UIPage page = Entity.Get<UIComponent>().Page;
            var rootElement = page.RootElement;
            var playButton = rootElement.FindVisualChildOfType<Button>("playButton");
            playButton.Click += delegate { Entity.Get<UIComponent>().Page = Entity.Scene.Entities[5].Get<UIComponent>().Page; };
        }

        public override void Update()
        {
            // Do stuff every new frame
        }
    }
}
