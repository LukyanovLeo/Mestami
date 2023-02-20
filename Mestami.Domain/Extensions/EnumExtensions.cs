﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum @enum)
            => @enum.GetType()
            .GetMember(@enum.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName() ?? "Unknown";
    }
}
