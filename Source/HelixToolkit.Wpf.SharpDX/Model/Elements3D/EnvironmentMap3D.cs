﻿using System.Windows;
using System.IO;

namespace HelixToolkit.Wpf.SharpDX
{
    using Model;
    using Model.Scene;

    public class EnvironmentMap3D : Element3D
    {

        public static readonly DependencyProperty TextureProperty = DependencyProperty.Register("Texture", typeof(Stream), typeof(EnvironmentMap3D),
            new PropertyMetadata(null,(d,e)=> 
            {
                ((d as Element3DCore).SceneNode as EnvironmentMapNode).Texture = (Stream)e.NewValue;
            }));

        public Stream Texture
        {
            set
            {
                SetValue(TextureProperty, value);
            }
            get
            {
                return (Stream)GetValue(TextureProperty);
            }
        }

        protected override SceneNode OnCreateSceneNode()
        {
            return new EnvironmentMapNode();
        }

        protected override void AssignDefaultValuesToSceneNode(SceneNode core)
        {
            base.AssignDefaultValuesToSceneNode(core);
            (SceneNode as EnvironmentMapNode).Texture = Texture;
        }
    }
}
