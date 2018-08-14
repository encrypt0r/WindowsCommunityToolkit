﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace Microsoft.Toolkit.Win32.UI.Controls.WinForms
{
    internal class InkToolbarCustomToolButtonDesigner : ControlDesigner
    {
        public override void InitializeNewComponent(IDictionary defaultValues)
        {
            base.InitializeNewComponent(defaultValues);

            var toolbarbutton = (InkToolbarCustomToolButton)Component;
            if (toolbarbutton != null)
            {
                // Set MinimumSize in the designer, so that the control doesn't go to 0-height
                toolbarbutton.MinimumSize = new System.Drawing.Size(20, 20);
                toolbarbutton.Dock = System.Windows.Forms.DockStyle.Top;
            }
        }

        public override bool CanBeParentedTo(IDesigner parentDesigner)
        {
            return base.CanBeParentedTo(parentDesigner);
        }
    }
}