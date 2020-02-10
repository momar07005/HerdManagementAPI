using System;
using System.Collections.Generic;
using System.Linq;

namespace HerdManagement.Domain.Common
{
    // Learn more: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/implement-value-objects
    public abstract class ValueObject<T> where T: ValueObject<T>
    {
        public override bool Equals(object objectToComparedWith)
        {
            var valueObject = objectToComparedWith as T;

            if (ReferenceEquals(valueObject, null))
                return false;

            if (ReferenceEquals(this, valueObject))
                return true;

            return EqualsCore(valueObject);
        }

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b) => a.Equals(b);

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b) => !(a == b);

        public override int GetHashCode() => GetHashCodeCore();

        protected  abstract bool EqualsCore(T obj);

        protected abstract int GetHashCodeCore();
    }
}
