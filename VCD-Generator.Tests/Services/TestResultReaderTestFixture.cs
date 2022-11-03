﻿// -------------------------------------------------------------------------------------------------
// <copyright file="TestResultReaderTestFixture.cs" company="RHEA System S.A.">
// 
//   Copyright 2022 RHEA System S.A.
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// 
// </copyright>
// ------------------------------------------------------------------------------------------------

using System.Security.Cryptography;

namespace VCD.Generator.Tests.Services
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    using NUnit.Framework;

    using VCD.Generator.Services;

    /// <summary>
    /// Suite of tests for the <see cref="TestResultReader"/> class
    /// </summary>
    [TestFixture]
    public class TestResultReaderTestFixture
    {
        private TestResultReader testResultReader;

        private DirectoryInfo directoryInfo;

        [SetUp]
        public void SetUp()
        {
            this.testResultReader = new TestResultReader();
        }

        [Test(Description = "Verifies that the Read methods trows an exception"), Property("REQUIREMENT-ID", "REQ-01")]
        public async Task Verify_that_Read_throws_exception()
        {
            Assert.That(async () => await this.testResultReader.Read(this.directoryInfo),
                Throws.TypeOf<NotImplementedException>());
        }
    }
}
