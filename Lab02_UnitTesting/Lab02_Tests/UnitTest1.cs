using System;
using Lab02_UnitTesting;
using Xunit;

namespace Lab02_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddOne() => Assert.Equal(1, Program.DepositMoneyMath(1));

        [Fact]
        public void CanAddOneMillion() => Assert.Equal(1000000, Program.DepositMoneyMath(1000000));

        [Fact]
        public void CanSubtractOne() => Assert.Equal(1, Program.WithdrawMoneyMath(1));

        [Fact]
        public void CanSubtractOneMillion() => Assert.Equal(1000000, Program.WithdrawMoneyMath(1000000));
    }



}
