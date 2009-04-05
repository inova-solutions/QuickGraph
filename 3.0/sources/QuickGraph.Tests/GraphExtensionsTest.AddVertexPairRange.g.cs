// <copyright file="GraphExtensionsTest.AddVertexPairRange.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace QuickGraph
{
    public partial class GraphExtensionsTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(GraphExtensionsTest))]
        [ExpectedException(typeof(ContractException))]
        public void AddVertexPairRange01()
        {
            if (!PexContract.HasRuntimeContracts(typeof(GraphExtensions)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            this.AddVertexPairRange<int>((IMutableVertexAndEdgeSet<int, SEdge<int>>)null,
            (IEnumerable<SEquatableEdge<int>>)null);
        }
    }
}
