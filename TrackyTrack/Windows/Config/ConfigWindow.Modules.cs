﻿namespace TrackyTrack.Windows.Config;

public partial class ConfigWindow
{
    private void Modules()
    {
        if (ImGui.BeginTabItem("Modules"))
        {
            ImGuiHelpers.ScaledDummy(5.0f);
            var changed = false;

            ImGui.TextColored(ImGuiColors.DalamudViolet, "Normal Modules:");
            ImGui.Indent(10.0f);
            changed |= ImGui.Checkbox("Enable Desynthesis Tracking", ref Configuration.EnableDesynthesis);
            ImGui.Unindent(10.0f);

            ImGuiHelpers.ScaledDummy(5.0f);
            ImGui.TextColored(ImGuiColors.DalamudViolet, $"AllaganTools ");
            ImGui.SameLine();

            var avail = Plugin.AllaganToolsConsumer.IsAvailable;
            if (avail)
                ImGui.TextColored(ImGuiColors.HealerGreen, $"(Available):");
            else
                ImGui.TextColored(ImGuiColors.DPSRed, $"(Not Available):");

            if (avail)
            {
                ImGui.Indent(10.0f);
                changed |= ImGui.Checkbox("Enable Venture Coffer Tracking", ref Configuration.EnableVentureCoffers);
                ImGui.Unindent(10.0f);
            }

            if (changed)
                Configuration.Save();

            ImGui.EndTabItem();
        }
    }
}
