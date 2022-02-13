using System;
using System.Runtime.Serialization;

namespace DRY.CustomException
{
    [Serializable]
    public class EntityNotFoundException : Exception
    {
        private const string DefaultMessage = "Entity does not exist.";

        public int EntityId { get; }

        public EntityNotFoundException() : base(DefaultMessage)
        {
        }

        public EntityNotFoundException(string message) : base(message)
        {
        }

        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public EntityNotFoundException(int entityId) : this($"{DefaultMessage}, ID : {entityId}")
        {
            EntityId = entityId;
        }

        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            EntityId = (int)info.GetValue(nameof(EntityId), typeof(int));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(EntityId), EntityId, typeof(int));
        }
    }
}
