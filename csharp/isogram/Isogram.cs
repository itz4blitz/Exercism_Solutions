﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        string wordFormatted = new string(word.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
        string trimmed = String.Concat(wordFormatted.Where(c => !Char.IsWhiteSpace(c)));
        var multipleLetters = trimmed.GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key).ToList();
        if (multipleLetters.Count > 0) return false;
        else return true;
    }
}
