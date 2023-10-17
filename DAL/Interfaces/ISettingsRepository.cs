﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    internal interface ISettingsRepository : IEntityRepository<SettingsModel>
    {
    }
}
