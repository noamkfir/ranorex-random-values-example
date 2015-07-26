/*
 * Created by Ranorex
 * User: Noam
 * Date: 2015-07-25
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace RandomValuesExample.Modules
{
    /// <summary>
    /// Description of GenerateRandomNumber.
    /// </summary>
    [TestModule("52E22C2C-3B3D-49BB-B7E5-8235A39FD79D", ModuleType.UserCode, 1)]
    public class GenerateRandomNumber : ITestModule
    {
    	string _Output = "";
    	[TestVariable("9945BD00-61F9-4DBF-A281-E7504E64D01F")]
    	public string Output
    	{
    		get { return _Output; }
    		set { _Output = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GenerateRandomNumber()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	var random = new Random();
        	var value = random.Next();
        	Output = value.ToString();
        }
    }
}
