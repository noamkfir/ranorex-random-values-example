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

namespace RandomValuesExample
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RandomValuesExampleRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.0")]
    [RepositoryFolder("47fd7a9d-3b39-4525-9a75-0900ce2b3a52")]
    public partial class RandomValuesExampleRepository : RepoGenBaseFolder
    {
        static RandomValuesExampleRepository instance = new RandomValuesExampleRepository();

        /// <summary>
        /// Gets the singleton class instance representing the RandomValuesExampleRepository element repository.
        /// </summary>
        [RepositoryFolder("47fd7a9d-3b39-4525-9a75-0900ce2b3a52")]
        public static RandomValuesExampleRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RandomValuesExampleRepository() 
            : base("RandomValuesExampleRepository", "/", null, 0, false, "47fd7a9d-3b39-4525-9a75-0900ce2b3a52", ".\\RepositoryImages\\RandomValuesExampleRepository47fd7a9d.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("47fd7a9d-3b39-4525-9a75-0900ce2b3a52")]
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
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.0")]
    public partial class RandomValuesExampleRepositoryFolders
    {
    }
#pragma warning restore 0436
}