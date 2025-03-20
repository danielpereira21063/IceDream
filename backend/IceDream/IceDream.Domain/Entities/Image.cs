using IceDream.Domain.Constants.ErrorMessages;

namespace IceDream.Domain.Entities
{
    public sealed class Image : AbstractEntity
    {
        public byte[] File { get; private set; }
        public bool Main { get; private set; }
        public Guid ProductId { get; private set; }
        public Product Product { get; private set; }

        public Image(Guid productId, byte[] file, bool main)
        {
            Validate(productId, file);
            File = file;
            Main = main;
            ProductId = productId;
        }

        private void Validate(Guid productId, byte[] file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException(ImageErrorMessage.InvalidFile);
            }

            if (productId == Guid.Empty)
            {
                throw new ArgumentException(ImageErrorMessage.InvalidProductId);
            }
        }
    }
}
