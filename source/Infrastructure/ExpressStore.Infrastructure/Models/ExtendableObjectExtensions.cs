namespace ExpressStore.Infrastructure.Models
{
    public static class ExtendableObjectExtensions
    {
        public static T GetData<T>(this IExtendableObject extendableObject, string name, bool handleType = false)
        {
            CheckNotNull(extendableObject, name);

            if (extendableObject == null)
            {
                throw new ArgumentNullException(nameof(extendableObject));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return extensionObject.GetData<T>(
                name,
                handleType
                    ? new JsonSerializer { TypeNameHandling = TypeNameHandling.All}
                    : JsonSerializer.CreateDefault()
            );
        }
        
    }
}