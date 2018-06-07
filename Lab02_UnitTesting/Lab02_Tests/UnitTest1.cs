using System;
using Lab02_UnitTesting;
using Xunit;

namespace Lab02_Tests
{
    public class UnitTest1
    {
       [Fact]
       public void CanAddZero() => Assert.Equal(1005000, Program.DepositMoneyMath(0));

       [Fact]
       public void CanAddOneMillion() => Assert.Equal(1005000, Program.DepositMoneyMath(1000000));
    }


}
