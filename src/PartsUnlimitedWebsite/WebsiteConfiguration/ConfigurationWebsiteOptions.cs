﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Framework.ConfigurationModel;
using PartsUnlimited.Telemetry;
using System;

namespace PartsUnlimited.WebsiteConfiguration
{
    public class ConfigurationWebsiteOptions : IWebsiteOptions
    {
        public ConfigurationWebsiteOptions(IConfiguration config, ITelemetryProvider log)
        {
            try
            {
                ShowRecommendations = config.Get<bool>("ShowRecommendations");
            }
            catch (InvalidCastException e)
            {
                log.TrackException(e);
            }
        }

        public bool ShowRecommendations { get; }
    }
}