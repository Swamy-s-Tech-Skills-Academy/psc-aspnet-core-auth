﻿using System.Security.Cryptography;
using System.Text;

namespace Globomantics.ApplicationCore.Extensions;

public static class StringExtensions
{
    public static string Sha256(this string input)
    {
        using SHA256 sha = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(input);
        var hash = sha.ComputeHash(bytes);

        return Convert.ToBase64String(hash);
    }
}
