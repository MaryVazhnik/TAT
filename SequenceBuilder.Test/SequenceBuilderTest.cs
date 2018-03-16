using System;
using DEV_2;
using Xunit;

namespace Sequence.Test
{
    public class SequenceBuilderTest
    {
        [Fact]
        public void EmptyStringTest()
        {
            // arrange
            string str = String.Empty;
            //act
            SequenceBuilder sb = new SequenceBuilder();
            //assert
            Assert.Null(sb.CheckEven(str));
        }
        [Fact]
        public void EvenIndexTest()
        {
            //arrange
            string str = "ababab";
            string result = "aaa";
            //act
            SequenceBuilder sb = new SequenceBuilder();
            //assert
            Assert.Equal(sb.CheckEven(str), result);
        }
    }
}