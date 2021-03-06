using System;
using System.Collections.Generic;

namespace LuckyDrawBot.Localizations
{
    public class LocalizationEnUs : BaseLocalization
    {
        private static readonly Dictionary<string, string> Strings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
        {
            ["Help.Message"] = "Hi there, To start a lucky draw type something like <b>@luckydraw secret gift, 1, 23:59</b>.<br/>Want more? Here is the cheat sheet:<br/>@luckydraw [prize name], [the number of prizes], [draw time], [the url of gift url]<br>",
            ["MainActivity.Description"] = "{0} prize(s). Time: {1}",
            ["MainActivity.JoinButton"] = "I am in",
            ["MainActivity.ViewDetailButton"] = "Detail",
            ["MainActivity.NoCompetitor"] = "",
            ["MainActivity.OneCompetitor"] = "{0} joined this lucky draw",
            ["MainActivity.TwoCompetitors"] = "{0} and {1} joined this lucky draw",
            ["MainActivity.ThreeCompetitors"] = "{0}, {1} and {2} joined this lucky draw",
            ["MainActivity.FourOrMoreCompetitors"] = "{0}, {1} and {2} others joined this lucky draw",
            ["ResultActivity.NoWinnerTitle"] = "No one joined, no winner",
            ["ResultActivity.NoWinnerSubtitle"] = "Prize: {0}",
            ["ResultActivity.NoWinnerImageUrl"] = "https://media.tenor.co/images/5d6e7c144fb4ef5985652ea6d7219965/raw",
            ["ResultActivity.WinnersTitle"] = "Our winners are: {0}",
            ["ResultActivity.WinnersSubtitle"] = "Prize: {0}",
            ["ResultActivity.WinnersImageUrl"] = "https://serverpress.com/wp-content/uploads/2015/12/congrats-gif-2.gif",
            ["CompetitionDetail.Competitors"] = "Players",
        };

        public LocalizationEnUs() : base(Strings)
        {
        }
    }
}