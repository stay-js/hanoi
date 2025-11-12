using HanoiLib;

namespace HanoiTest
{
    public class HanoiTests
    {
        [Test]
        public void CtorThrowsArgumentOutOfRangeExceptionIfNIsLessThanOne()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Hanoi(0));
        }

        [Test]
        public void MoveReturnsFalseIfTryingToMoveToAPoleWithASmallerDisk()
        {
            var game = new Hanoi(3);
            game.Move("A", "B");

            Assert.That(game.Move("A", "B").IsSuccessful, Is.False);
        }

        [Test]
        public void MoveReturnsFalseIfTryingToMoveFromEmptyPole()
        {
            var game = new Hanoi(3);

            Assert.That(game.Move("B", "A").IsSuccessful, Is.False);
        }

        [Test]
        public void MoveReturnsFalseIfFromAndToAreTheSame()
        {
            var game = new Hanoi(3);

            Assert.That(game.Move("A", "A").IsSuccessful, Is.False);
        }

        [Test]
        public void MoveReturnsTrueForGameIsFinishedWhenGameIsFinished()
        {
            var game = new Hanoi(3);

            game.Move("A", "C");
            game.Move("A", "B");
            game.Move("C", "A");
            game.Move("A", "B");
            game.Move("A", "C");
            game.Move("B", "A");
            game.Move("A", "B");
            game.Move("B", "A");
            game.Move("B", "C");
            
            Assert.That(game.Move("A", "C").IsFinished, Is.True);
        }
    }
}
