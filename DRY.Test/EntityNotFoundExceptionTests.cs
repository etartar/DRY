using DRY.CustomException;
using NUnit.Framework;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DRY.Test
{
    [TestFixture]
    public class EntityNotFoundExceptionTests
    {
        private const string Message = "Hi Spaceman";
        private const int EntityId = 1;
        
        [Test]
        public void WhenNoArgs_ThenSetMessageToDefault()
        {
            var exception = new EntityNotFoundException();

            Assert.That(exception.Message, Is.EqualTo("Entity does not exist."));
        }

        [Test]
        public void WhenMessageSpecified_ThenSetMessage()
        {
            var exception = new EntityNotFoundException(Message);

            Assert.That(exception.Message, Is.EqualTo(Message));
        }

        [Test]
        public void WhenMessageAndInnerExSpecified_ThenSetMessageAndInnerEx()
        {
            var innerException = new EntityNotFoundException();

            var exception = new EntityNotFoundException(Message, innerException);

            Assert.That(exception.Message, Is.EqualTo(Message));
            Assert.That(exception.InnerException, Is.SameAs(innerException));
        }

        [Test]
        public void WhenIdSpecified_ThenSetProperty()
        {
            var exception = new EntityNotFoundException(EntityId);

            Assert.That(exception.Message, Is.EqualTo($"Entity does not exist., ID : {EntityId}"));
            Assert.That(exception.EntityId, Is.EqualTo(EntityId));
        }

        [Test]
        public void WhenSerialized_ThenDeserializeCorrectly()
        {
            var exception = new EntityNotFoundException(EntityId);

            var result = Serializer.SerializeAndDeserialize(exception);

            Assert.That(result.EntityId, Is.EqualTo(exception.EntityId));
            Assert.That(result.ToString(), Is.EqualTo(exception.ToString()));
        }
    }

    internal static class Serializer
    {
        public static TException SerializeAndDeserialize<TException>(TException exception)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, exception);

                stream.Seek(0, 0);

                return (TException)formatter.Deserialize(stream);
            }
        }
    }
}