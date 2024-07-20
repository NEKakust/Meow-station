﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Administration.UI.Logs;

[GenerateTypedNameReferences]
public sealed partial class AdminLogsWindow : DefaultWindow
{
    public AdminLogsWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
