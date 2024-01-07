using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Modules.Commands;
using Microsoft.Extensions.Localization;

namespace MapCycle;

public static class LocalizationExtension
{
    public static void ReplyLocalized(this CommandInfo info, IStringLocalizer localizer, string key, params object[] args)
    {
        string value = localizer[key, args];
        value = value.Replace("%prefix%", localizer["prefix"]);
        info.ReplyToCommand(value);
    }

    public static void PrintLocalizedChatAll(IStringLocalizer localizer, string key, params object[] args)
    {
        string value = localizer[key, args];
        value = value.Replace("%prefix%", localizer["prefix"]);
        Server.PrintToChatAll(value);
    }
}