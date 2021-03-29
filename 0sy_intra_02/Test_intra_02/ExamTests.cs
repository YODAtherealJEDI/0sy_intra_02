using Xunit;
using FluentAssertions;
using _0sy_intra_02;
using System.Reflection;
using System.Collections.Generic;
using System;

namespace Test_intra_02
{
    public class ExamTests
    {
        /// <summary>
        /// Assembly under test
        /// </summary>
        Assembly aut;
        IEnumerable<Type> typeList;
        string ns;

        public ExamTests()
        {
            aut = typeof(X).Assembly;

            typeList = aut.ExportedTypes;

            // Récupère le premier namespace
            foreach (var t in typeList)
            {
                ns = t.Namespace;
                break;
            }
            
        }

        [Fact]
        public void AtLeastOnePublicType()
        {
            typeList.Should().NotBeEmpty();

        }

        [Theory]
        [InlineData("X")]
        public void PublicClass_X_Should_Exists(string classname)
        {
            
            // Remplacer le namespace
            object obj = aut.CreateInstance($"{ns}.{classname}");
           
            obj.Should().NotBeNull($"La classe **{classname}** n'existe pas!");
        }
    }
}
