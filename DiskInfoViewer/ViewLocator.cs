/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/.
 *
 * Copyright (c) 2026 Florian K.
 */

using Avalonia.Controls;
using Avalonia.Controls.Templates;
using DiskInfoViewer.ViewModels;

namespace DiskInfoViewer
{
    public class ViewLocator : IDataTemplate
    {
        public Control Build(object param)
        {
            if (param is null)
                return null;

            switch (param)
            {
                case StorageViewModel:
                    return new Views.StorageView();
                default:
                    return new TextBlock { Text = "Not Found: " + param.GetType().FullName };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
