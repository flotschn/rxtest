﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Conditions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ConditionsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("c303d3a2-9d3a-4921-b9e0-0c10d12d7117")]
    public partial class ConditionsRepository : RepoGenBaseFolder
    {
        static ConditionsRepository instance = new ConditionsRepository();

        /// <summary>
        /// Gets the singleton class instance representing the ConditionsRepository element repository.
        /// </summary>
        [RepositoryFolder("c303d3a2-9d3a-4921-b9e0-0c10d12d7117")]
        public static ConditionsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ConditionsRepository() 
            : base("ConditionsRepository", "/", null, 0, false, "c303d3a2-9d3a-4921-b9e0-0c10d12d7117", ".\\RepositoryImages\\ConditionsRepositoryc303d3a2.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c303d3a2-9d3a-4921-b9e0-0c10d12d7117")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class ConditionsRepositoryFolders
    {
    }
#pragma warning restore 0436
}