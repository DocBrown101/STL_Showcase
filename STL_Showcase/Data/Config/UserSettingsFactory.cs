﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL_Showcase.Data.Config
{
    public class UserSettingsFactory
    {

        public enum SettingsType
        {
            NETSettings,
            JSONSettings
        }

        public static IUserSettings GetSettings(SettingsType t)
        {
            switch (t)
            {
                case SettingsType.NETSettings:
                    return UserSettingsNET.Instance;
                case SettingsType.JSONSettings:
                    return UserSettingsJSON.Instance;
                default:
                    throw new NotImplementedException($"Settings mode for {t.ToString()} is not implemented.");
            }
        }
    }
}
