using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.AIAggregate.Facts
{
    public partial class F_UploadedFile : BaseEntity, IAggregateRoot
    {
        #region Simple Prob
        public string ContentType { get; private set; }
        public byte[] Content { get; private set; }
        #endregion        
        public F_UploadedFile SetContentType(string contentType)
        {
            ContentType = contentType;
            return this;
        }
        public F_UploadedFile SetContent(byte[] content)
        {
            Content = content;
            return this;
        }
    }
}