﻿namespace TheSurvivors.Domain.Context
{
    public interface IConnectionStringProvider
    {
        string ConnectionString { get; }
    }
}