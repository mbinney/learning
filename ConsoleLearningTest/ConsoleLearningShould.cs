using ConsoleLearning;
using System;
using Xunit;
using Moq;

namespace ConsoleLearningTest
{
    public class ConsoleLearningShould
    {
        [Fact]
        public void HoldClaimWhenUnderAge()
        {

            Mock<IClaimant> mockClaimant = new Mock<IClaimant>();

            mockClaimant.Setup(x => x.Age).Returns(14);

            //Act
            var sut = new Claim(mockClaimant.Object);
            var decision = sut.PayClaim();

            //Assert

            Assert.Equal(ClaimStatus.Held, decision);

        }

        [Fact]
        public void HoldClaimWhenOverAge()
        {
            Mock<IClaimant> mockClaimant = new Mock<IClaimant>();

            mockClaimant.Setup(x => x.Age).Returns(66);

            var sut = new Claim(mockClaimant.Object);

            var decision = sut.PayClaim();

            Assert.Equal(ClaimStatus.Held, decision);

        }

        [Fact]
        public void PayClaimWhenRightAge()
        {

            Mock<IClaimant> mockClaimant = new Mock<IClaimant>();
            mockClaimant.Setup(x => x.Age).Returns(20);

            var sut = new Claim(mockClaimant.Object);

            var decision = sut.PayClaim();

            Assert.Equal(ClaimStatus.Paid, decision);
        }

        [Fact]
        public void CancelClaimWhenInvalidAge()
        {
            Mock<IClaimant> mockClaimant = new Mock<IClaimant>();
            mockClaimant.Setup(x => x.Age).Returns(0);

            var sut = new Claim(mockClaimant.Object);

            var decision = sut.PayClaim();

            Assert.Equal(ClaimStatus.Cancelled, decision);


        }


    }
}
