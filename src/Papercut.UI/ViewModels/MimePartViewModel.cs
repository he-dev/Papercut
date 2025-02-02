﻿// Papercut
// 
// Copyright © 2008 - 2012 Ken Robertson
// Copyright © 2013 - 2024 Jaben Cargman
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using Caliburn.Micro;

namespace Papercut.ViewModels;

public class MimePartViewModel : Screen
{
    string _partText;

    string _windowTitle = "Mime Part Viewer";

    public string WindowTitle
    {
        get => this._windowTitle;
        set
        {
            this._windowTitle = value;
            this.NotifyOfPropertyChange(() => this.WindowTitle);
        }
    }

    public string PartText
    {
        get => this._partText;
        set
        {
            this._partText = value;
            this.NotifyOfPropertyChange(() => this.PartText);
        }
    }

    public async Task Close()
    {
        await this.TryCloseAsync(false);
    }
}