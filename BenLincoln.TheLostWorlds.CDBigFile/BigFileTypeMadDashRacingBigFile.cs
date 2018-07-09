﻿// BenLincoln.TheLostWorlds.CDBigFile
// Copyright 2006-2018 Ben Lincoln
// http://www.thelostworlds.net/
//

// This file is part of BenLincoln.TheLostWorlds.CDBigFile.

// BenLincoln.TheLostWorlds.CDBigFile is free software: you can redistribute it and/or modify
// it under the terms of version 3 of the GNU General Public License as published by
// the Free Software Foundation.

// BenLincoln.TheLostWorlds.CDBigFile is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with BenLincoln.TheLostWorlds.CDBigFile (in the file LICENSE.txt).  
// If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using BF = BenLincoln.TheLostWorlds.CDBigFile;

namespace BenLincoln.TheLostWorlds.CDBigFile
{
    public class BigFileTypeMadDashRacingBigFile : BigFileType
    {
        public BigFileTypeMadDashRacingBigFile()
            : base()
        {
            Name = "MadDashRacingBigFile";  // as opposed to RKV files, which use a different format that is not yet supported
            Description = "Blood Omen 2 (PlayStation 2/Xbox/PC) / Mad Dash Racing (Xbox)";
            MasterIndexType = IndexType.MadDashRacingBigFile;
            FileTypes = new FileType[]
            {
                BF.FileType.FromType(BF.FileType.FILE_TYPE_DDS),
                new FileType()
            };
        }

        public override void LoadHashLookupTable(string bigfilePath)
        {
            BloodOmen2HashLookupTable hlt = new BloodOmen2HashLookupTable("BO2", bigfilePath);
            hlt.LoadHashTable();
            HashLookupTable = hlt;
        }
    }
}
