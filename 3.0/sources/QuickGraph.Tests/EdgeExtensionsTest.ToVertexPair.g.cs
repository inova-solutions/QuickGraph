// <copyright file="EdgeExtensionsTest.ToVertexPair.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
using QuickGraph.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Exceptions;
using System.Diagnostics.Contracts;

namespace QuickGraph
{
    public partial class EdgeExtensionsTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        [ExpectedException(typeof(ContractException))]
        public void ToVertexPair01()
        {
            if (!PexContract.HasRuntimeContracts(typeof(EdgeExtensions)))
                Assert.Inconclusive
                    ("assembly QuickGraph is not instrumented with runtime contracts");
            SEquatableEdge<int> vertexPair;
            vertexPair = this.ToVertexPair<int, Edge<int>>((Edge<int>)null);
        }
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeExtensionsTest))]
        public void ToVertexPair02()
        {
            Edge<int> edge;
            SEquatableEdge<int> vertexPair;
            edge = EdgeFactory.Create(0, 0);
            vertexPair = this.ToVertexPair<int, Edge<int>>(edge);
        }
    }
}
