﻿using System;
using PropertyChanged;

namespace Tel.Egram.Components.Workspace
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ContentContext : IDisposable
    {
        public int SelectedIndex { get; set; }
        
        public ContentContext(ContentKind kind)
        {
            SelectedIndex = (int) kind;
        }

        public abstract void Dispose();
    }
}