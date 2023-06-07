﻿namespace Najd.Md.Items;

public static class ItemsDbProperties
{
    public static string DbTablePrefix { get; set; } = "";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Items";
}
